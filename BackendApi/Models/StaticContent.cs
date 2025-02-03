using System.ComponentModel.DataAnnotations;

namespace BackendApi.Models
{
    public class StaticContent
    {
        [Key] public int ContentID { get; set; }
        public string Product { get; set; }
        public string Seller { get; set; }
        public string ProductDes { get; set; }

    }
}
