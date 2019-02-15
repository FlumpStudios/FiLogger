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

                //Setup up logging. PM: 15/02/2019
                var connectionString = appSettings.GetConnectionString("DefaultConnection");
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
                    // Close and flush the log.
                    Log.CloseAndFlush();
                }
            }

            public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
                WebHost.CreateDefaultBuilder(args)
                    .UseSerilog() // Set serilog as the loggin provider.
                    .UseStartup<Startup>();
        }
    }
