using System;
using System.Collections.Generic;
using System.Text;

namespace FiLogger.Common.Settings
{
    public class AppSettings : IAppSettings
    {
        public API API { get; set; }
        public Swagger Swagger { get; set; }
        public Database Database { get; set; }
    }

    public class API
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class Swagger
    {
        public bool Enabled { get; set; }
    }

    public class Database
    {
        public string ConnectionString { get; set; }
        public bool UseInMemoryDatabase { get; set; }
        public bool SeedDbOnCreate { get; set; }
    }


}
