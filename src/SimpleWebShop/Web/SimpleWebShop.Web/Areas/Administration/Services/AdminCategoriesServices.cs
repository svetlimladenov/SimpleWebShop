using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SimpleWebShop.Data.Common;
using SimpleWebShop.Data.Models;
using SimpleWebShop.Web.Areas.Administration.ViewModels;

namespace SimpleWebShop.Web.Areas.Administration.Services
{
    public class AdminCategoriesServices : IAdminCategoriesServices
    {
        private readonly IDbRepository<Category> categoriesRepository;
        private readonly IMapper mapper;

        public AdminCategoriesServices(IDbRepository<Category> categoriesRepository, IMapper mapper)
        {
            this.categoriesRepository = categoriesRepository;
            this.mapper = mapper;
        }

        public void CreateCategory(CreateCategoryInputModel inputModel)
        {
            var category = this.mapper.Map<Category>(inputModel);
            category.Id = Guid.NewGuid().ToString();
            this.categoriesRepository.Add(category);
            this.categoriesRepository.Save(); //TODO Fix save changes async 
        }
        public void DeleteCategory(string id)
        {
            var categoryToDelete = this.categoriesRepository.GetById(id);
            this.categoriesRepository.Delete(categoryToDelete);
            this.categoriesRepository.Save();
        }

        public void HardDeleteCategory(string id)
        {
            var categoryToDelete = this.categoriesRepository.AllWithDeleted().FirstOrDefault(x => x.Id == id);
            this.categoriesRepository.HardDelete(categoryToDelete);
            this.categoriesRepository.Save();
        }

        public void BringBackCategory(string id)
        {
            var category = this.categoriesRepository.AllWithDeleted().FirstOrDefault(x => x.Id == id);
            category.IsDeleted = false;
            this.categoriesRepository.Save();
        }
    }
}