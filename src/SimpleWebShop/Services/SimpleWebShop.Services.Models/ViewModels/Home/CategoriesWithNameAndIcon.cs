using SimpleWebShop.Data.Models;
using SimpleWebShop.Services.Mapping;

namespace SimpleWebShop.Services.Models.ViewModels.Home
{
    public class CategoriesWithNameAndIcon : IMapFrom<Category>
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public string IconClass { get; set; }

        public bool IsDeleted { get; set; }
    }
}