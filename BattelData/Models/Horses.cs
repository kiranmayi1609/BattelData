using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelData.Models
{
    public partial class Horses
    {
        [Key]
       
        public int Id { get; set; }

        
        public string Name { get; set; }

        [ForeignKey("Samurai")]
        public int SamuraiId { get; set; }

        public virtual Samurai Samurai { get; set; }
    }
}
