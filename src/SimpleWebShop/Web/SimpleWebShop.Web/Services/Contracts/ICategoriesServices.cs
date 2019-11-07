using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleWebShop.Web.Areas.Administration.ViewModels;
using SimpleWebShop.Web.ViewModels.Home;

namespace SimpleWebShop.Web.Services.Contracts
{
    public interface ICategoriesServices
    {
        void CreateCategory(CreateCategoryInputModel inputModel);

        ICollection<CategoriesWithNameAndIcon> GetCategoriesForLinks();
    }
}
