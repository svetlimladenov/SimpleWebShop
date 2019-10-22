using SimpleWebShop.Data.Common.Models;

namespace SimpleWebShop.Data.Models
{
    public class Shipper : BaseModel<string>
    {
        public string CompanyName { get; set; }

        public string CompanyWebSite { get; set; }

        public string Phone { get; set; }
    }
}