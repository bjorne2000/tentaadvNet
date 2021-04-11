using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHamster.Ticker
{
    public class TickEventArgs : EventArgs
    {
        public DateTime CurrentTime { get; set; }
        public bool CancellationRequested { get; set; }
        public TickEventArgs(DateTime currentTime, bool cancellationRequested = false)
        {
            this.CurrentTime = currentTime;
            this.CancellationRequested = cancellationRequested;
        }
    }
}

