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

        public ICollection<string> GetAllCategoriesNames()
        {
            var names = this.categoriesRepository.All().Select(x => x.Name).ToArray();
            return names;
        }

        public ICollection<CategoriesWithNameAndIcon> GetAllWithDeletedCategories(int page, int perPage = 10)
        {
            var result = this.categoriesRepository
                .AllWithDeleted()
                .OrderBy(x => x.CreatedOn)
                .Skip(perPage * (page - 1))
                .Take(perPage)
                .To<CategoriesWithNameAndIcon>()
                .ToArray();
            return result;
        }

        public string GetCategoryIdByName(string name)
        {
            var categoryId = this.categoriesRepository.All().FirstOrDefault(x => x.Name == name)?.Id;
            return categoryId;
        }

        public int GetCategoriesCount()
        {
            var count = this.categoriesRepository.AllWithDeleted().Count();
            return count;
        }
    }
}