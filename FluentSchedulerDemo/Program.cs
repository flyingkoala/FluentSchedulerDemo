using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FluentScheduler;
using FluentSchedulerDemo.FluentScheduler;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FluentSchedulerDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseUrls("http://*:80")
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();
            ConfigureJobs(host.Services);
            host.Run();
        }


        internal static void ConfigureJobs(IServiceProvider serviceProvider)
        {
            JobManager.JobFactory = new StructureMapJobFactory(serviceProvider);

            JobManager.JobException += info =>
                Console.Out.WriteLine("Error with job: " + info.Exception.Message);
            JobManager.Initialize(new JobRegistry());
        }
    }
}
