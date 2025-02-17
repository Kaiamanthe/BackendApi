using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BackendApi.Areas.Identity.Data;

namespace BackendApi.Models
{
    public class DynamicContent
    {
        [Key] public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        [ForeignKey(nameof(Author))]
        public string AuthorID { get; set; }
        public BackendApiUser Author { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
