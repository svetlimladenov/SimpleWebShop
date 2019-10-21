using SimpleWebShop.Data.Common.Models;

namespace SimpleWebShop.Data.Models
{
    public class Product : BaseModel<string>
    {
        //adding basic custom products for testing.

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }
    }
}
