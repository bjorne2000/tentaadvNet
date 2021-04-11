using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHamster.Object
{
    public class MotionsBatch
    {
        public int ID { get; set; }

        public virtual Hamster activeHamster { get; set; }
        public virtual Motionsyta yta { get; set; }

        public MotionsBatch(Hamster _hamster, Motionsyta _yta)
        {
            activeHamster = _hamster;
            yta = _yta;
        }
        public MotionsBatch()
        {

        }
    }
}
