using AutoMapper;
using FiLogger.Common.Extensions;
using FiLogger.Common.Settings;
using ListersDemo.API.Swagger;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using FiLogger.IoC.Config.Profiles;
using CryptoLib;
using DBContext = FiLogger.Context.Data;
using FiLogger.DataAccess.Repositories;
using FiLogger.Service.Contracts;
using FiLogger.Service.Services;

namespace FiLogger
{
    public class Startup
    {
        public IConfiguration _configuration { get; private set; }
        public IHostingEnvironment HostingEnvironment { get; private set; }

        private AppSettings _appSettings;

        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            HostingEnvironment = env;
            _configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();

            //API Explorer (for API Versioning)
            // add the versioned api explorer, which also adds IApiVersionDescriptionProvider service
            // note: the specified format code will format the version as "'v'major[.minor][-status]"
            services.AddVersionedApiExplorer(
                options =>
                {
                    options.GroupNameFormat = "'v'VVV";

                    // note: this option is only necessary when versioning by url segment. the SubstitutionFormat
                    // can also be used to control the format of the API version in route templates
                    options.SubstituteApiVersionInUrl = true;
                });

            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_2);

            //API Version
            services.AddApiVersioning(
                    options =>
                    {
                        options.ReportApiVersions = true;
                        options.AssumeDefaultVersionWhenUnspecified = true;
                        options.DefaultApiVersion = new ApiVersion(1, 0);
                        options.ApiVersionReader = new UrlSegmentApiVersionReader();
                    }
                );

            //App settings
            var appSettingsSection = _configuration.GetSection("AppSettings");
            if (appSettingsSection == null)
                throw new System.Exception("No appsettings section has been found");

            services.Configure<AppSettings>(appSettingsSection);

            _appSettings = appSettingsSection.Get<AppSettings>();

            if (_appSettings.IsValid())
            {
                if (_appSettings.Swagger.Enabled)
                {
                    // Register the Swagger generator, defining 1 or more Swagger documents
                    services.AddSwaggerGen(options =>
                    {
                        // resolve the IApiVersionDescriptionProvider service
                        // note: that we have to build a temporary service provider here because one has not been created yet
                        var provider = services.BuildServiceProvider().GetRequiredService<IApiVersionDescriptionProvider>();

                        // add a swagger document for each discovered API version
                        // note: you might choose to skip or document deprecated API versions differently
                        foreach (var description in provider.ApiVersionDescriptions)
                        {
                            options.SwaggerDoc(description.GroupName, CreateInfoForApiVersion(description));
                        }

                        // add a custom operation filter which sets default values
                        options.OperationFilter<SwaggerDefaultValues>();

                        // integrate xml comments
                        //options.IncludeXmlComments(XmlCommentsFilePath);

                    });
                }
            }

            //Automap settings
            services.AddAutoMapper();
            ConfigureMaps();

            
            //Setup the DB context
            if (_appSettings.Database.UseInMemoryDatabase)
            {
                string inMemDbName = string.Format("{0}_database", _appSettings.API.Title);

                services.AddDbContext<DBContext.AP_ReplacementContext>(options =>
                    options.UseInMemoryDatabase(inMemDbName));                
            }
            else
            {
                services.AddDbContext<DBContext.AP_ReplacementContext>(options => 
                    options.UseSqlServer(_appSettings.Database.ConnectionString));
            }


            AddCustomServices(services);

        }

        private void AddCustomServices(IServiceCollection services)
        {
            //Read the encyption keys from the Secrets
            var inputString = _configuration["EncryptionCipher:inputString"];
            var salt = _configuration["EncryptionCipher:Salt"];

            //Add the CryptoManager service through DI and pass through the input string and salt to the contructor
            //The keys are kept in the secret folder for developement. When running for the first time you will need to add the EncryptionCipher:inputString and EncryptionCipher:sale to your secrets.
            services.AddTransient<ICryptoManager>(s => new CryptoManager(inputString, salt));

            services.AddTransient<ICustomerRepository, CustomerRepository>();

            services.AddTransient<ICustomerService, CustomerService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IApiVersionDescriptionProvider provider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //Pretty much let anyone from anywhere access our API.
            //Origins will be specified when we are closer to production and have some established clients - PM 14/02/2019

            if (_appSettings.IsValid())
            {
                if (_appSettings.Swagger.Enabled)
                {
                    app.UseSwagger();

                    // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
                    // specifying the Swagger JSON endpoint.
                    app.UseSwaggerUI(options =>
                    {
                        // build a swagger endpoint for each discovered API version

                        foreach (var description in provider.ApiVersionDescriptions)
                        {
                            options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.GroupName.ToUpperInvariant());
                        }

                        options.RoutePrefix = string.Empty;

                    });
                }
            }

            app.UseCors(builder => builder.AllowAnyHeader().AllowAnyOrigin().AllowCredentials().AllowAnyMethod());
            app.UseHttpsRedirection();
            app.UseMvc();
        }


        #region Startup helper functions
        Info CreateInfoForApiVersion(ApiVersionDescription description)
        {
            var info = new Info()
            {
                Title = $"{_appSettings.API.Title} {description.ApiVersion}",
                Version = description.ApiVersion.ToString(),
                Description = _appSettings.API.Description
            };

            if (description.IsDeprecated)
            {
                string.Format("{0} This API version has been deprecated.", info.Description);
            }
            return info;
        }

        private void ConfigureMaps()
        {
            //Mapping settings
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<CustomerMappingProfile>();                
            }
         );
        }    
        #endregion
    }
}
