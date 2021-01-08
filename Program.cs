using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarCampareToolRESTAPI.DbContexts;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CarCampareToolRESTAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                try
                {
                    var contaxt = scope.ServiceProvider.GetService<CarCompareContext>();
                    contaxt.Database.EnsureDeleted();
                    contaxt.Database.Migrate();
                }
                catch(Exception ex)
                {
                    var logs = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
                    logs.LogError(ex, "Error");
                }
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
