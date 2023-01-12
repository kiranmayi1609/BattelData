using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelData.Models
{
    public partial class Weapon
    {
        [Key]
        
        public int ID { get; set; }
        public string Name { get; set; }

        public int SamuraiID { get; set; }

        public virtual Samurai Samurai { get; set; }
    }
}
