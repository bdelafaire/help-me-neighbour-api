namespace HelpMeNeighbour.Models
{
    public class MessageResponseModel
    {
        public MessageResponseModel(string adId, string userId, string content) {
            this.AdId = adId;
            this.UserId = userId;
            this.Content = content;
        }

        public string AdId { get; set; }

        public string UserId { get; set; }

        public string Content { get; set; }
    }
}
