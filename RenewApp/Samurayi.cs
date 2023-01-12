using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenewApp
{
    public class Samurayi 
    {
        public int ID { get; set; }


        public string Name { get; set; }

        public virtual ICollection<Horses> Horses { get; set; }


    }
}
