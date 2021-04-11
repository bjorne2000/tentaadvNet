using System.Collections.Generic;

namespace BackendHamster
{
    public class Cage
    {
        public int ID { get; set; }
        public virtual int cageNumber { get; set; }        
        public Cage()
        {

        }
        public Cage(int _cageNumber)
        {
            cageNumber = _cageNumber;
        }

    }
}