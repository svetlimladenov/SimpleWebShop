using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using AutoMapper;
using SimpleWebShop.Data.Common;
using SimpleWebShop.Data.Models;
using SimpleWebShop.Services.Data.Contracts;
using SimpleWebShop.Services.Mapping;
using SimpleWebShop.Services.Models.ViewModels.Categories;
using SimpleWebShop.Services.Models.ViewModels.Home;

namespace SimpleWebShop.Services.Data
{
    public class CategoriesServices : ICategoriesServices
    {
        private readonly IDbRepository<Category> categoriesRepository;
        private readonly IMapper mapper;

        public CategoriesServices(IDbRepository<Category> categoriesRepository, IMapper mapper)
        {
            this.categoriesRepository = categoriesRepository;
            this.mapper = mapper;
        }

        public ICollection<CategoriesWithNameAndIcon> GetCategoriesForLinks()
        {
            var classesAndNames = this.categoriesRepository
                .All()
                .Where(x => x.ParentCategoryId == null)
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

        public ICollection<string> GetAllParentCategoriesNames()
        {
            var names = this.categoriesRepository.All().Where(x => x.ParentCategoryId == null).Select(x => x.Name).ToArray();
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

        public string NormalizeCategoryName(string name)
        {
            var normalized = name.Replace('-', ' ');
            return normalized;
        }

        public SingleCategoryViewModel GetCategoryViewModel(string name)
        {
            name = this.NormalizeCategoryName(name);
            var viewModel = this.categoriesRepository.AllWithDeleted()
                .Select(x => new SingleCategoryViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    IconClass = x.IconClass,
                    Active = x.Active,
                    CreatedOn = x.CreatedOn,
                    DeletedOn = x.DeletedOn,
                    IsDeleted = x.IsDeleted,
                    ModifiedOn = x.ModifiedOn,
                    ParentCategoryId = x.ParentCategoryId,
                    ChildCategories = x.ChildCategories,
                    Products = x.Products
                }).FirstOrDefault(x => x.Name == name);
            
            return viewModel;
        }   
    }
}