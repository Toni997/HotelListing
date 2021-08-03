using System;
using Autofac;
using HotelListing.IRepository;
using HotelListing.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;

namespace HotelListing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // var containerBuilder = new ContainerBuilder();
            // containerBuilder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            //
            // var container = containerBuilder.Build();
            //
            // var notificationService = container.Resolve<IUnitOfWork>();

            Log.Logger = new LoggerConfiguration().WriteTo.File(
                path: @"C:\hotellistings\logs\log-.txt",
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
                rollingInterval: RollingInterval.Day,
                restrictedToMinimumLevel: LogEventLevel.Information
            ).CreateLogger();


            try
            {
                Log.Information("Application is starting");
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception e)
            {
                Log.Fatal(e, "Application failed to start");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}
