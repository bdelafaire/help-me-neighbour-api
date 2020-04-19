using System.ComponentModel.DataAnnotations;

namespace HelpMeNeighbour.Models
{
    public class MessageRequestModel
    {
        [Required]
        public string Token { get; set; }

        [Required]
        public string AdId { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
