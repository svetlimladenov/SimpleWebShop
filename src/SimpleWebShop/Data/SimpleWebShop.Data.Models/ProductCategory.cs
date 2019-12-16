using System;
using System.Collections.Generic;
using SimpleWebShop.Data.Common.Models;

namespace SimpleWebShop.Data.Models
{
    public class ProductCategory : BaseModel<string>
    {
        public ProductCategory()
        {
            this.Products = new HashSet<Product>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public string IconClass { get; set; }

        public bool Active { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}