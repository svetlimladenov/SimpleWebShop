using System.Linq;
using SimpleWebShop.Data.Common;
using SimpleWebShop.Data.Models;
using SimpleWebShop.Services.Mapping;
using SimpleWebShop.Web.Areas.Administration.ViewModels;

namespace SimpleWebShop.Web.Areas.Administration.Services
{
    public class UsersServices : IUsersServices
    {
        private readonly IDbRepository<ApplicationUser> users;

        public UsersServices(IDbRepository<ApplicationUser> users)
        {
            this.users = users;
        }
        public AllUsersViewModel GetAllUsers()
        {
            var viewModel = new AllUsersViewModel()
            {
                AllUsers = this.users.AllWithDeleted().To<BasicUserViewModel>().ToArray()
            };

            return viewModel;
        }
    }
}