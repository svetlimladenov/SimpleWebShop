using System.Collections.Generic;
using SimpleWebShop.Services.Models.ViewModels.Categories;
using SimpleWebShop.Services.Models.ViewModels.Home;

namespace SimpleWebShop.Services.Data.Contracts
{
    public interface ICategoriesServices
    {
        ICollection<CategoriesWithNameAndIcon> GetCategoriesForLinks();

        ICollection<string> GetAllCategoriesNames();

        ICollection<string> GetAllParentCategoriesNames();

        ICollection<CategoriesWithNameAndIcon> GetAllWithDeletedCategories(int page, int perPage);

        string GetCategoryIdByName(string name);

        int GetCategoriesCount();

        string NormalizeCategoryName(string name);

        SingleCategoryViewModel GetCategoryViewModel(string name);
    }
}
