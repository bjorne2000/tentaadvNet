using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendHamster
{
    public class Hamster
    {
        public enum Gender { Male, Feamale}


        public int ID { get; set; }
        public virtual string name { get; set; }
        public virtual int age { get; set; }
        public virtual string ownerName { get; set; }
        public virtual Gender gender { get; set; }
        public virtual DateTime senastMotioneradTid { get; set; }
        public virtual DateTime inCheck { get; set; }

        public Hamster()
        {

        }

    }
}