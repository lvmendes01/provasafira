using Lvmendes.Prova.Repositorio;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Lvmendes.Super.WeApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RegisterMappings.Register();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseIISIntegration();//Leonardo
                    webBuilder.UseContentRoot(Directory.GetCurrentDirectory());
                });
    }
}