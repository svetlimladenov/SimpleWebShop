using System;
using System.Collections.Generic;
using SimpleWebShop.Data.Common;
using SimpleWebShop.Data.Models;
using SimpleWebShop.Services.Data.Contracts;
using System.Linq;
using System.Linq.Expressions;

namespace SimpleWebShop.Services.Data
{
    public class ProductsControlPanelServices : IProductsControlPanelServices
    {
        private readonly IDbRepository<Product> productsRepository;
        private readonly IDbRepository<Category> categoriesRepository;

        public ProductsControlPanelServices(IDbRepository<Product> productsRepository, IDbRepository<Category> categoriesRepository)
        {
            this.productsRepository = productsRepository;
            this.categoriesRepository = categoriesRepository;
        }
        public int GetAllProductsCount()
        {
            return this.productsRepository.All().Count();
        }

        public int GetAllCategoriesCount()
        {
            return this.categoriesRepository.All().Count();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> where)
        {
            return this.productsRepository.All().Where(where).ToList();
        }
    }
}