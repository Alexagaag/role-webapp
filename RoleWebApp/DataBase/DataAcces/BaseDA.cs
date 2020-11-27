using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RoleWebApp.DataBase.DataAcces
{
    public class BaseDA
    {
        public string GetConnection()

        {

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();
            return builder.GetSection("ConnectionStrings").GetSection("RWADB").Value;


        }
    }
}
