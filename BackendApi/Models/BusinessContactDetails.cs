using System.ComponentModel.DataAnnotations;

namespace BackendApi.Models
{
    public class BusinessContactDetails
    {
        [Key] public int ContactID { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
               
    }
}
