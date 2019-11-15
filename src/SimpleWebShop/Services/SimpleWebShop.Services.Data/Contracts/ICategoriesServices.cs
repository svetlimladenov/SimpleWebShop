using System.Collections.Generic;
using SimpleWebShop.Services.Models.ViewModels.Home;

namespace SimpleWebShop.Services.Data.Contracts
{
    public interface ICategoriesServices
    {
        ICollection<CategoriesWithNameAndIcon> GetCategoriesForLinks();

        ICollection<CategoriesWithNameAndIcon> GetAllCategories();
    }
}
