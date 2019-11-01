using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWebShop.Web.Areas.Administration.ViewModels
{
    public class BasicUserViewModel
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public bool IsDeleted { get; set; }
    }
}