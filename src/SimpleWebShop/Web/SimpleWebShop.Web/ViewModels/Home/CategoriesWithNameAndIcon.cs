using SimpleWebShop.Data.Models;
using SimpleWebShop.Services.Mapping;

namespace SimpleWebShop.Web.ViewModels.Home
{
    public class CategoriesWithNameAndIcon : IMapFrom<ProductCategory>
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public string IconClass { get; set; }
    }
}