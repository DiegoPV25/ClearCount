using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ClearCount
{
    public class PopulationHostedService: IHostedService, IDisposable
    {

        private Timer _timer;

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(SendInfo, null, TimeSpan.Zero, TimeSpan.FromSeconds(2));
            return Task.CompletedTask;
        }

        private void SendInfo(object state)
        {
            throw new NotImplementedException();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
