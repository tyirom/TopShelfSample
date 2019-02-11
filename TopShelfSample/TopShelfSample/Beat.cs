using System.Timers;
using NLog;

namespace TopShelfSample
{
    public class Beat
    {
        private readonly Timer _timer;
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public Beat()
        {
            _timer = new Timer(1000)
            {
                AutoReset = true
            };
            _timer.Elapsed += (sender, eventArgs) => _logger.Info("I am fine");
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