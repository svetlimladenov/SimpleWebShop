using System.Threading.Tasks;
using SimpleWebShop.Web.Areas.Administration.ViewModels;

namespace SimpleWebShop.Web.Areas.Administration.Services
{
    public interface IAdminCategoriesServices
    {
        void CreateCategory(CreateCategoryInputModel inputModel);

        void DeleteCategory(string id);

        void BringBackCategory(string id);
    }
}