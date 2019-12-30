using System.Collections.Generic;
using SimpleWebShop.Services.Models.ViewModels.Categories;

namespace SimpleWebShop.Services.Models.ViewModels.Home
{
    public class HomeIndexViewModel
    {
        public ICollection<SingleCategoryViewModel> CategoriesLinks { get; set; }
    }
}