using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleWebShop.Web.Areas.Administration.ViewModels;

namespace SimpleWebShop.Web.Areas.Administration.Services
{
    public interface IAdminProductsServices
    {
        void CreateProduct(CreateProductInputModel model);
    }
}