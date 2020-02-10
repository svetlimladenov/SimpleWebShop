using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SimpleWebShop.Data.Models;

namespace SimpleWebShop.Services.Data.Contracts
{
    public interface IProductsControlPanelServices
    {
        int GetAllProductsCount();

        int GetAllCategoriesCount();

        List<Product> GetAll(Expression<Func<Product, bool>> where);
    }   
}