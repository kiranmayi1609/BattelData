using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelData.Models
{
    public partial class S_Battle
    {
        [Key]
        public int ID { get; set; }

        public int BattelID { get; set; }

        public int SamuraiID { get; set; }

        public virtual Battle Battle { get; set; }

        public virtual Samurai Samurai { get; set; }
    }
}
