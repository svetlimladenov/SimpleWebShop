using System;
using AutoMapper;
using SimpleWebShop.Data.Common;
using SimpleWebShop.Data.Models;
using SimpleWebShop.Services.Data.Contracts;
using SimpleWebShop.Web.Areas.Administration.ViewModels;

namespace SimpleWebShop.Web.Areas.Administration.Services
{
    public class AdminProductsServices : IAdminProductsServices
    {
        private readonly IDbRepository<Product> productsRepository;
        private readonly ICategoriesServices categoriesServices;
        private readonly IMapper mapper;

        public AdminProductsServices(
            IDbRepository<Product> productsRepository,
            ICategoriesServices categoriesServices,
            IMapper mapper
        )
        {
            this.productsRepository = productsRepository;
            this.categoriesServices = categoriesServices;
            this.mapper = mapper;
        }
        public void CreateProduct(CreateProductInputModel model)
        {
            var categoryId = this.categoriesServices.GetCategoryIdByName(model.ProductCategoryName);

            var productMapper = this.mapper.Map<Product>(model);
            productMapper.CategoryId = categoryId;
            productMapper.Id = Guid.NewGuid().ToString();

            this.productsRepository.Add(productMapper);
            this.productsRepository.Save();
        }
    }
}