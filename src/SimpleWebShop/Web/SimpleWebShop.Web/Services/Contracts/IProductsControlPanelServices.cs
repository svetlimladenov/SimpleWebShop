using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWebShop.Web.Services.Contracts
{
    public interface IProductsControlPanelServices
    {
        int GetAllProductsCount();

        int GetAllCategoriesCount();
    }
}