using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHamster.Object
{
    public class CageBuddies
    {
        public int ID { get; set; }
        public virtual Hamster cageHamster{get;set;}
        public virtual Cage filledCage { get; set; }

        public CageBuddies(Hamster _hamster, Cage _cage)
        {
            cageHamster = _hamster;
            filledCage = _cage;
        }
        public CageBuddies()
        {

        }
    }
}
