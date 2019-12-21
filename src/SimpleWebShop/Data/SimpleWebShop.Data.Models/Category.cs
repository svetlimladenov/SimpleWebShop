using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using SimpleWebShop.Data.Common.Models;

namespace SimpleWebShop.Data.Models
{
    public class Category : BaseModel<string>
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public string IconClass { get; set; }

        public bool Active { get; set; }

        [ForeignKey("ParentCategory")]
        public string ParentCategoryId { get; set; }

        public virtual Category ParentCategory { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}