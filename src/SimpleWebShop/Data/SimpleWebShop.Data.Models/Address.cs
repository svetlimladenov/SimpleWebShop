using SimpleWebShop.Data.Common.Models;

namespace SimpleWebShop.Data.Models
{
    public class Address : BaseModel<string>
    {
        public string AddressLine { get; set; }

        public string PostCode { get; set; }

        public string Town { get; set; }

        public string Region { get; set; }

        public string Country { get; set; }
    }
}