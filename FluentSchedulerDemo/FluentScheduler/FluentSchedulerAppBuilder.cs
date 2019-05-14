using FluentScheduler;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentSchedulerDemo.FluentScheduler
{
    /// <summary>
    /// 
    /// </summary>
    public static class FluentSchedulerAppBuilder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseFluentScheduler(this IApplicationBuilder app)
        {
            JobManager.JobFactory = new StructureMapJobFactory(app.ApplicationServices);

            JobManager.JobException += info =>
                Console.Out.WriteLine("Error with job: " + info.Exception.Message);
            JobManager.Initialize(new JobRegistry());

            return app;
        }
    }
}
