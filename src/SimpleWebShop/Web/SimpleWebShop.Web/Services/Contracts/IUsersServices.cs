using SimpleWebShop.Web.Areas.Administration.ViewModels;

namespace SimpleWebShop.Web.Services.Contracts
{
    public interface IUsersServices
    {
        AllUsersViewModel GetAllUsers();
    }
}