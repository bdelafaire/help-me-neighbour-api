using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HelpMeNeighbour.Entities
{
    [Table("message")]
    public class Message
    {
        [Column("id")]
        public string Id { get; set; }
        [Column("content")]
        public string Content { get; set; }
        [Column("sended_date")]
        public DateTime SendedDate { get; set; }
        [Column("id_author")]
        public User Author { get; set; }
        [Column("id_ad")]
        public Ad Ad { get; set; }

    }
}
