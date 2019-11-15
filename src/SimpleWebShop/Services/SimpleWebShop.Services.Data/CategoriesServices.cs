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
            //var classesAndNames = this.categoriesRepository.All().OrderBy(x => x.CreatedOn)
            //    .Select(x => new CategoriesWithNameAndIcon
            //    {
            //        Id = x.Id,
            //        Name = x.Name,
            //        IconClass = x.IconClass
            //    }).ToList();

            var classesAndNames = this.categoriesRepository.All().OrderBy(x => x.CreatedOn).To<CategoriesWithNameAndIcon>().ToArray();

            return classesAndNames;
        }

        public ICollection<CategoriesWithNameAndIcon> GetAllCategories()
        {
            var result = this.categoriesRepository.All().To<CategoriesWithNameAndIcon>().ToList();
            return result;
        }
    }
}