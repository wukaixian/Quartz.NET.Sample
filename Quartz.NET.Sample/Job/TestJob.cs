using System;

namespace Quartz.NET.Sample.Job
{
    /// <summary>
    /// TestJob
    /// DisallowConcurrentExecution:禁止并发执行
    /// </summary>
    [DisallowConcurrentExecution]
    public class TestJob : JobBase
    {
        public override void Execute(IJobExecutionContext context)
        {
            Log.Info($"{CurrentJobName} is start");

            try
            {
                //your job task running here.
                Console.WriteLine("task running");
            }
            catch (Exception e)
            {
                Log.Error($"{CurrentJobName} excute exception.");
                Log.Error(e);
            }

            Log.Info($"{CurrentJobName} is end.");
        }
    }
}