using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HelpMeNeighbour.Entities
{
    [Table("ad_category")]
    public class AdCategory
    {
        [Column("id_ad")]
        public string IdAd { get; set; }
        [Column("id_category")]
        public string IdCategory { get; set; }
        public Ad Ad { get; set; }
        public Category Category { get; set; }
    }
}
