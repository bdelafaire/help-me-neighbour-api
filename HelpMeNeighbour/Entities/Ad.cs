using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HelpMeNeighbour.Entities
{
    [Table("ad")]
    public class Ad
    {
        [Column("id")]
        public string Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("creation_date")]
        public DateTime CreatedDate { get; set; }
        [Column("address")]
        public string Address { get; set; }
        [Column("bonus")]
        public string Bonus { get; set; }
        [Column("picture")]
        public string Picture { get; set; }
        public ICollection<AdCategory> AdCategories { get; set; }
        public ICollection<Message> Messages { get; set; }
        [Column("UserId")]
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
