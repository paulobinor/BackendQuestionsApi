﻿using ETM.Core.Helpers;
using Microsoft.Extensions.Configuration;
using UserManagementApi.Core.Models;

namespace GTB.TRMS.WS
{
    public class ConfigSettings
    {
        static IConfigurationBuilder builder = new ConfigurationBuilder();
        static IConfigurationRoot _ConfigRoot;
        private static string ApplicationExeDirectory()
        {
            var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var appRoot = Path.GetDirectoryName(location);
            return appRoot;
        }

        static private IConfigurationRoot GetAppSettings()
        {

            var builder = new ConfigurationBuilder()
            .SetBasePath(ApplicationExeDirectory())
            .AddJsonFile("appsettings.json");
            if (_ConfigRoot == null)
            {
                _ConfigRoot = builder.Build();
            }
            return _ConfigRoot;
        }

        public static ConnectionStrings ConnectionStrings => GetAppSettings().GetSection("ConnectionStrings").Get<ConnectionStrings>();
        public static AppSettings AppSettings => GetAppSettings().GetSection("AppSettings").Get<AppSettings>();


    
    }
}
