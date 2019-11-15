using System;
using SimpleWebShop.Data.Common;
using SimpleWebShop.Data.Models;
using SimpleWebShop.Web.Areas.Administration.ViewModels;

namespace SimpleWebShop.Web.Areas.Administration.Services
{
    public class AdminCategoriesServices : IAdminCategoriesServices
    {
        private readonly IDbRepository<ProductCategory> categoriesRepository;

        public AdminCategoriesServices(IDbRepository<ProductCategory> categoriesRepository)
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
        public void DeleteCategory(string id)
        {
            var categoryToDelete = this.categoriesRepository.GetById(id);
            this.categoriesRepository.Delete(categoryToDelete);
            this.categoriesRepository.Save();
        }
    }
}