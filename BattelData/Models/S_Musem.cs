using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelData.Models
{
    public partial class S_Musem
    {
        [Key]
        public int ID { get; set; }

        public int SamuraiID { get; set; }

        public int MusemID { get; set; }

        public virtual Museum Museum { get; set; }

        public virtual Samurai Samurai { get; set; }
    }
}
