using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HelpMeNeighbour.Entities
{
    [Table("review")]
    public class Review
    {
        [Column("id")]
        public string Id { get; set; }
        [Column("grade")]
        public int Grade { get; set; }
        [Column("comment")]
        public string Comment { get; set; }
        public User Reviewed { get; set; }
        [Column("id_reviewed")]
        public string IdReviewed { get; set; }
        public User Reviewer { get; set; }
        [Column("id_reviewer")]
        public string IdReviewer { get; set; }
    }
}
