using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HelpMeNeighbour.Entities
{
    [Table("user")]
    public class User
    {
        [Column("id")]
        public string Id { get; set; }
        [Column("lastname")]
        public string LastName { get; set; }
        [Column("firstname")]
        public string FirstName { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("salt")]
        public string Salt { get; set; }
        [Column("password")]
        public string Password { get; set; }
        [Column("adress")]
        public string Address { get; set; }
        [Column("zipcode")]
        public string ZipCode { get; set; }
        [Column("city")]
        public string City { get; set; }
        [Column("state")]
        public string State { get; set; }
        public ICollection<Message> Messages { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Ad> Ads { get; set; }

        //reviews créee
        public ICollection<Review> CreatedReviews { get; set; }

        [NotMapped]
        public string Token { get; set; }
    }
}
