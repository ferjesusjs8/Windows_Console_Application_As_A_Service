using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace HeartBeat
{
    public class HeartBeats
    {
        private readonly Timer _timer;

        public HeartBeats()
        {
            _timer = new Timer(1000) { AutoReset = true };
            _timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            string[] lines = new string[] { $"{DateTime.Now}" };
            File.AppendAllLines(@"C:\Test\Demos\Heartbeat.txt", lines);
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }
    }
}
