using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace FiLogger
{  
        public class Program
        {
            public static void Main(string[] args)
            {
                var appSettings = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

                //Setup up serilog logging. PM: 15/02/2019
                var connectionString = appSettings.GetSection("AppSettings:Database:ConnectionString").Value;
                var SqlTable = appSettings.GetSection("Logging:sqlTable").Value;

                Log.Logger = new LoggerConfiguration()
                   .MinimumLevel.Error()            
                   .Enrich.FromLogContext()
                   .WriteTo.MSSqlServer(
                                connectionString,
                               SqlTable,
                               autoCreateSqlTable: true)
                   .CreateLogger();

                try
                {
                    CreateWebHostBuilder(args).Build().Run();
                }
                finally
                {
                    Log.CloseAndFlush();
                }
            }

            public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
                WebHost.CreateDefaultBuilder(args)
                    .UseSerilog()
                    .UseStartup<Startup>();
        }
    }
