using System;
using static BackendHamster.Object.Aktivities;

namespace BackendHamster
{
    public class AktivityLogg
    {
        public int ID { get; set; }
        public virtual Hamster hamsterLogg { get; set; }
        public virtual DateTime timeLogg { get; set; }
        public virtual aktivities aktivitet { get; set; }

        public AktivityLogg()
        {

        }
    }
}