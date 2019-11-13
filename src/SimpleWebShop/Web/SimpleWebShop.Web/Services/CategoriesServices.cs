using System;
using System.Collections.Generic;
using System.Linq;
using SimpleWebShop.Data.Common;
using SimpleWebShop.Data.Models;
using SimpleWebShop.Web.Areas.Administration.ViewModels;
using SimpleWebShop.Web.Services.Contracts;
using SimpleWebShop.Web.ViewModels.Home;

namespace SimpleWebShop.Web.Services
{
    public class CategoriesServices : ICategoriesServices
    {
        private readonly IDbRepository<ProductCategory> categoriesRepository;

        public CategoriesServices(IDbRepository<ProductCategory> categoriesRepository)
        {
            this.categoriesRepository = categoriesRepository;
        }
        public void CreateCategory(CreateCategoryInputModel inputModel)
        {
            var category = new ProductCategory()
            {
                Id = Guid.NewGuid().ToString(),
                Description = inputModel.Description,
                Name = inputModel.Name,
                IconClass = inputModel.IconClass,
            };

            this.categoriesRepository.Add(category);
            this.categoriesRepository.Save();
        }

        public ICollection<CategoriesWithNameAndIcon> GetCategoriesForLinks()
        {
            var classesAndNames = this.categoriesRepository.All().OrderBy(x => x.CreatedOn).Select(x => new CategoriesWithNameAndIcon
            {
                Id = x.Id,
                Name = x.Name,
                IconClass = x.IconClass
            }).ToList();

            return classesAndNames;
        }

        public ICollection<CategoriesWithNameAndIcon> GetAllCategories()
        {
            var result = this.categoriesRepository.All().Select(x => new CategoriesWithNameAndIcon()
            {
                Id = x.Id,
                IconClass = x.IconClass,
                Name = x.Name
            }).ToList();
            return result;
        }

        public void DeleteCategory(string id)
        {
            var categoryToDelete = this.categoriesRepository.GetById(id);
            this.categoriesRepository.Delete(categoryToDelete);
            this.categoriesRepository.Save();
        }
    }
}