using System.Collections.Generic;

namespace SimpleWebShop.Services.Models.ViewModels.Home
{
    public class HomeIndexViewModel
    {
        public ICollection<CategoriesWithNameAndIcon> CategoriesLinks { get; set; }
    }
}