using System.IO;
using Topshelf;

namespace Quartz.NET.Sample
{
    class Program
    {
        static void Main(string[] args)
        {

            Directory.SetCurrentDirectory(System.AppDomain.CurrentDomain.BaseDirectory);
            HostFactory.Run(x =>
            {
                x.RunAsLocalSystem();

                x.SetDescription("测试-定时任务-wiindow");
                x.SetDisplayName("Test.Window.Service");
                x.SetServiceName("Test.Window.Service");

                x.Service(factory =>
                {
                    QuartzServer server = QuartzServerFactory.CreateServer();
                    server.Initialize();
                    return server;
                });
            });
        }
    }
}
