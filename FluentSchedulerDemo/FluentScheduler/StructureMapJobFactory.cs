using FluentScheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace FluentSchedulerDemo.FluentScheduler
{
    /// <summary>
    /// 
    /// </summary>
    public class StructureMapJobFactory : IJobFactory
    {
        private readonly IServiceProvider _buildServiceProvider;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="buildServiceProvider"></param>
        public StructureMapJobFactory(IServiceProvider buildServiceProvider)
        {
            _buildServiceProvider = buildServiceProvider;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public IJob GetJobInstance<T>() where T : IJob
        {
            return _buildServiceProvider.GetService<T>();
        }
    }
}
