using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHamster.Object
{

    
    public class Aktivities
    {
        public int ID { get; set; }
        public  enum aktivities { ankomst, motion, dagbur, avhämtning }

        public Aktivities()
        {

        }
    }
}
