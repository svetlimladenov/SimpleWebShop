using System.Collections.Generic;
using SimpleWebShop.Data.Common.Models;

namespace SimpleWebShop.Data.Models
{
    public class Product : BaseModel<string>
    {
        public Product()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Color { get; set; }

        public string Size { get; set; }

        public double Weight { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public string Details { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; }

        public int ProductsOnStock { get; set; }

        public string ProductCategoryId { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
