using System;
using System.Collections.Generic;
using SimpleWebShop.Data.Common.Models;

namespace SimpleWebShop.Data.Models
{
    public class Product : BaseModel<string>
    {
        public Product()
        {
            this.OrderDetails = new HashSet<OrderProduct>();
            this.UserReviews = new HashSet<UserProductReview>();
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Color { get; set; }

        public string Size { get; set; }

        public double Weight { get; set; }

        public string Description { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; }

        public int ProductsOnStock { get; set; }

        public string CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<OrderProduct> OrderDetails { get; set; }

        public virtual ICollection<UserProductReview> UserReviews { get; set; }
    }
}
