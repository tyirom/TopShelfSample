using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace TopShelfSample
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service<Beat>(s =>
                {
                    s.ConstructUsing(name => new Beat());
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });

                x.RunAsLocalSystem();
                x.SetDescription("Just beating program");
                x.SetDisplayName("BeatingProgram");
                x.SetServiceName("BeatingService");
            });
        }
    }
}
