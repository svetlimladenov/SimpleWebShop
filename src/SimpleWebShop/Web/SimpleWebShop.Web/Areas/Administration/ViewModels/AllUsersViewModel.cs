using System.Collections.Generic;

namespace SimpleWebShop.Web.Areas.Administration.ViewModels
{
    public class AllUsersViewModel
    {
        public ICollection<BasicUserViewModel> AllUsers { get; set; }
    }
}