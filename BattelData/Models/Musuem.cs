using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelData.Models
{
    public partial class Museum
    {
      
        public Museum()
        {
            S_Musem = new HashSet<S_Musem>();
        }

        [Key]
        public int ID { get; set; }

        
        public string Name { get; set; }

        public string Place { get; set; }

       
        public virtual ICollection<S_Musem> S_Musem { get; set; }
    }
}
