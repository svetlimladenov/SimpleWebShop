using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWebShop.Web.Areas.Administration.ViewModels
{
    public class AllUsersViewModel
    {
        public ICollection<BasicUserViewModel> AllUsers { get; set; }
    }
}