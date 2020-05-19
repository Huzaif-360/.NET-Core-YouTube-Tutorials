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

        /*DotNet Core Youtube Tutorial 7
         * ASP NET Core out of process hosting
         * 
         * Internet................ HTTP.................. IIS(w3wp Web running Server)
         * 
         * Our Application is being hosted in IIS(w3wp Web running Server) 
         * 
         * WithIn InProcess Hosting there is only one server
         * 
         * Inprocess Hosting is better than out Porcess Hosting
         * 
         * 
         * 
         * 
         * ....................................................
         * 
         * To make Out Process hosting 2 methods:
         * 1. To Replace inPrcess with OutPorcess
         *      <ASPCoreHostingModel>OutOfProcess</ASPCoreHostingModel>
         *          
         * 2. To remove entire Line, As the default setting is for OutProcess Hosting 
         * 
         * 
         * 
         * 
         * Internal (Client): ..............Kestrel Web Server
         * External Web Server:.............. Apache, IIS etc.
         * 
         * For OutOfProcess Kestrel WebServer is used to make connection of the application with the internet via HTTP
         * 
         * ....................................................................................................................................................................................
         * 
         * OutOFProcess Hosting:
         * 
         * 1: Internal (Client): ......HTTP........Kestrel Web Server  ............................(Less Secure)
         * 2: Internal (Client): ...HTTP...(Apache/IIS/Ngnix)....HTTP....Kestrel Web Server........(More Secure due to extra Configuration by external web server)
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
