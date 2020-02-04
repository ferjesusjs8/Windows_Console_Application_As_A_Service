using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace HeartBeat
{
    class Program
    {
        static void Main(string[] args)
        {
            var exitCode = HostFactory.Run(x =>
            {
                x.Service<HeartBeats>(service =>
                {
                    service.ConstructUsing(heartBeat => new HeartBeats());
                    service.WhenStarted(heartBeat => heartBeat.Start());
                    service.WhenStopped(heartBeat => heartBeat.Stop());
                });

                x.RunAsLocalSystem();

                x.SetServiceName("HeartBeatService");
                x.SetDisplayName("Heart Beat Service");
                x.SetDescription("Service used to create a service from a console app");
            });

            int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());

            Environment.ExitCode = exitCodeValue;
        }
    }
}
