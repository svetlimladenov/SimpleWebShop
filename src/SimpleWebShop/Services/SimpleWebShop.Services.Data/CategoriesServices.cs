using System.Collections.Generic;
using System.Linq;
using SimpleWebShop.Data.Common;
using SimpleWebShop.Data.Models;
using SimpleWebShop.Services.Data.Contracts;
using SimpleWebShop.Services.Mapping;
using SimpleWebShop.Services.Models.ViewModels.Home;

namespace SimpleWebShop.Services.Data
{
    public class CategoriesServices : ICategoriesServices
    {
        private readonly IDbRepository<ProductCategory> categoriesRepository;

        public CategoriesServices(IDbRepository<ProductCategory> categoriesRepository)
        {
            this.categoriesRepository = categoriesRepository;
        }

        public ICollection<CategoriesWithNameAndIcon> GetCategoriesForLinks()
        {
            var classesAndNames = this.categoriesRepository
                .All()
                .OrderBy(x => x.CreatedOn)
                .To<CategoriesWithNameAndIcon>()
                .ToArray();
            return classesAndNames;
        }

        public ICollection<CategoriesWithNameAndIcon> GetAllWithDeletedCategories()
        {
            var result = this.categoriesRepository
                .AllWithDeleted()
                .To<CategoriesWithNameAndIcon>()
                .ToArray();
            return result;
        }

        public string GetCategoryIdByName(string name)
        {
            var categoryId = this.categoriesRepository.All().FirstOrDefault(x => x.Name == name)?.Id;
            return categoryId;
        }
    }
}