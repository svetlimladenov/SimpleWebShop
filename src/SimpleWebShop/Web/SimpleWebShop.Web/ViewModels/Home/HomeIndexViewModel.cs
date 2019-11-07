using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWebShop.Web.ViewModels.Home
{
    public class HomeIndexViewModel
    {
        public ICollection<CategoriesWithNameAndIcon> CategoriesLinks { get; set; }
    }
}