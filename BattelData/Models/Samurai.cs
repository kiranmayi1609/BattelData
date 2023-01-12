using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelData.Models
{
    public partial class Samurai
    {
        public Samurai()
        {
            Horses = new HashSet<Horses>();
            S_Battle = new HashSet<S_Battle>();
            S_Musem = new HashSet<S_Musem>();
            Weapons = new HashSet<Weapon>();
        }

        [Key]
        public int ID { get; set; }

       
        public string Name { get; set; }

        public virtual ICollection<Horses> Horses { get; set; }

        
        public virtual ICollection<S_Battle> S_Battle { get; set; }

       
        public virtual ICollection<S_Musem> S_Musem { get; set; }

        
        public virtual ICollection<Weapon> Weapons { get; set; }
    }
}

