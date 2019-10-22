using SimpleWebShop.Data.Common.Models;

namespace SimpleWebShop.Data.Models
{
    public class ProductImage : BaseModel<string>
    {
        public string Url { get; set; }

        public string ProductId { get; set; }

        public Product Product { get; set; }
    }
}