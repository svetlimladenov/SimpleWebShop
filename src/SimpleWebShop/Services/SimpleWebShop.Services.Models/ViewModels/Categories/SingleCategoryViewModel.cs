using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SimpleWebShop.Data.Models;
using SimpleWebShop.Services.Mapping;

namespace SimpleWebShop.Services.Models.ViewModels.Categories
{
    public class SingleCategoryViewModel : IMapFrom<Category>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string IconClass { get; set; }

        public bool Active { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public string ParentCategoryId { get; set; }

        public ICollection<Product> Products { get; set; }

        public ICollection<BasicCategoryViewModel> ChildCategories { get; set; }
    }
}
