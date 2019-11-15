using System.Collections.Generic;

namespace SimpleWebShop.Web.ViewModels.Home
{
    public class HomeIndexViewModel
    {
        public ICollection<CategoriesWithNameAndIcon> CategoriesLinks { get; set; }
    }
}