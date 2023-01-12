using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelData.Models
{
    public partial class Battle
    {
        
        public Battle()
        {
            S_Battle = new HashSet<S_Battle>();
        }

        [Key]
        public int ID { get; set; }

       
        public string Name { get; set; }

        
        public DateTime? BattelYear { get; set; }

       
        public virtual ICollection<S_Battle> S_Battle { get; set; }
    }
}
