using SimpleWebShop.Web.Areas.Administration.ViewModels;

namespace SimpleWebShop.Web.Areas.Administration.Services
{
    public interface IUsersServices
    {
        AllUsersViewModel GetAllUsers();
    }
}