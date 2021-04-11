using BackendHamster.Operations;
using BackendHamster.Ticker;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace klocka
{
    public class Klocka
    {
        private int ticks { get; set; }
        private int dagar { get; set; }
        public Klocka(int _ticks, int _dagar)
        {
            ticks = _ticks;
            dagar = _dagar * 100;
        }
        public Klocka()
        {

        }
        public event EventHandler<TickEventArgs> KollatKlockan;

        private int antalTick;
        public async Task StartTicker()
        {
            TickEventArgs tickEventArgs = new TickEventArgs(DateTime.Now);
            while (!tickEventArgs.CancellationRequested)
            {
                await Task.Delay(ticks);
                antalTick++;
                tickEventArgs.CurrentTime = DateTime.Now;
                KollatKlockan?.Invoke(this, tickEventArgs);
                bool slut = antalTick == dagar;
                Console.Clear();
                if(slut)
                {
                    tickEventArgs.CancellationRequested = true;
                    EndOfDay.TakeOutHamsters();
                }

            }
        }
    }
}
