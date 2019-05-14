using FluentScheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentSchedulerDemo.FluentScheduler.Jobs
{
    public class Job1 : IJob
    {
        public void Execute()
        {
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
