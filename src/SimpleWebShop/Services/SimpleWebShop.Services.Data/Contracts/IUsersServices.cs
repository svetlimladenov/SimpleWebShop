using SimpleWebShop.Web.Areas.Administration.ViewModels;

namespace SimpleWebShop.Services.Data.Contracts
{
    public interface IUsersServices
    {
        AllUsersViewModel GetAllUsers();
    }
}