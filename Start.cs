using BackendHamster.Operations;
using klocka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHamster
{
    public class Start
    {
        public async Task StartProgram()
        {
            

                Console.WriteLine("Hur många dagar vill du köra?");
                int dag = int.Parse(Console.ReadLine());
                Console.WriteLine("Hur snabba ska ticken vara?");
                int tick = int.Parse(Console.ReadLine());

               var ticker = new Klocka(tick,dag);

            var manage = new cageManagement();
            
            
            manage.HamstersToCage();

            ticker.KollatKlockan += manage.TickEvent;
            await ticker.StartTicker();
        }
    }
}
