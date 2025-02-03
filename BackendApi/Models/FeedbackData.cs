using System.ComponentModel.DataAnnotations;

namespace BackendApi.Models
{
    public class FeedbackData
    {
        [Key] public int FeedbackId { get; set; }
        public string Blogger { get; set; }
        public string Feedback { get; set; }
        public string PublishDate { get; set; }
    }
}
