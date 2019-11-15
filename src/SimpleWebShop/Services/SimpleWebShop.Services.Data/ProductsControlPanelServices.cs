using SimpleWebShop.Data.Common;
using SimpleWebShop.Data.Models;
using SimpleWebShop.Services.Data.Contracts;
using System.Linq;

namespace SimpleWebShop.Services.Data
{
    public class ProductsControlPanelServices : IProductsControlPanelServices
    {
        private readonly IDbRepository<Product> productsRepository;
        private readonly IDbRepository<ProductCategory> categoriesRepository;

        public ProductsControlPanelServices(IDbRepository<Product> productsRepository, IDbRepository<ProductCategory> categoriesRepository)
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
    }
}