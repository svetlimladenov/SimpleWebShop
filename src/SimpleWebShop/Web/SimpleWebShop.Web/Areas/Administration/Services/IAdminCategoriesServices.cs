using System.Threading.Tasks;
using SimpleWebShop.Web.Areas.Administration.ViewModels;

namespace SimpleWebShop.Web.Areas.Administration.Services
{
    public interface IAdminCategoriesServices
    {
        void CreateCategory(CreateCategoryInputModel dto);

        void DeleteCategory(string id);

        void HardDeleteCategory(string id);

        void BringBackCategory(string id);
    }
}