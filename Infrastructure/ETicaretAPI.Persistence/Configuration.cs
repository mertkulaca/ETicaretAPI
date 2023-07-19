using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence
{
     public static class Configuration
    {
         public static string ConnectionString
        {
            get{
                ConfigurationManager manager = new();
                manager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ETicaretAPI.Presentation"));
                manager.AddJsonFile("appsettings.json");
                return manager.GetConnectionString("PostgreSQL");
            }
        }
    }
}
