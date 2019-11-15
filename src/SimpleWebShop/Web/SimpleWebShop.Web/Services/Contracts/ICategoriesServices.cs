using System.Collections.Generic;
using SimpleWebShop.Web.Areas.Administration.ViewModels;
using SimpleWebShop.Web.ViewModels.Home;

namespace SimpleWebShop.Web.Services.Contracts
{
    public interface ICategoriesServices
    {
        void CreateCategory(CreateCategoryInputModel inputModel);

        ICollection<CategoriesWithNameAndIcon> GetCategoriesForLinks();

        ICollection<CategoriesWithNameAndIcon> GetAllCategories();
        void DeleteCategory(string id);
    }
}
