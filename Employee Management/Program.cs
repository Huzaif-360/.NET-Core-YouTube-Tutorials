using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Employee_Management
{
    public class Program

        /*DotNet Core Youtube Tutorial 8
         * ERROR 
         * ASP NET Core launchsettings json file
         * An unhandled exception of type 'System.IO.FileNotFoundException' occurred in Unknown Module.
Could not load file or assembly 'System.Runtime, Version=4.2.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' or one of its dependencies. The system cannot find the file specified.

The program '[10816] Employee Management.dll' has exited with code 0 (0x0).
         * 
        */
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
