using FluentScheduler;
using FluentSchedulerDemo.FluentScheduler.Jobs;

namespace FluentSchedulerDemo.FluentScheduler
{
    /// <summary>
    /// 
    /// </summary>
    public class JobRegistry : Registry
    {
        /// <summary>
        /// 
        /// </summary>
        public JobRegistry()
        {
            // 立即执行每10秒一次的计划任务。（指定一个时间间隔运行，根据自己需求，可以是秒、分、时、天、月、年等。）
            Schedule<Job1>().ToRunNow().AndEvery(10).Seconds();
        }
    }
}
