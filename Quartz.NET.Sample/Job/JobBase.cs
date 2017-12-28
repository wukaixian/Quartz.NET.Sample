using Common.Logging;

namespace Quartz.NET.Sample.Job
{
    public abstract class JobBase:IJob
    {
        protected string CurrentJobName;
        protected ILog Log;

        protected JobBase()
        {
            CurrentJobName = this.GetType().Name;
            Log = LogManager.GetLogger(CurrentJobName);
        }

        public abstract void Execute(IJobExecutionContext context);
    }
}