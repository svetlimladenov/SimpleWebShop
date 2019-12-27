using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AutoMapper;
using SimpleWebShop.Data.Models;
using SimpleWebShop.Services.Mapping;

namespace SimpleWebShop.Web.Areas.Administration.ViewModels
{
    public class CreateCategoryInputModel : IMapTo<Category>
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        [MinLength(10,ErrorMessage = "The Description should be at least 10 symbols ")]
        public string Description { get; set; }

        [Required]  
        public string IconClass { get; set; }

        public string ParentCategoryName { get; set; }

        public List<string> AllFontAwesomeIcons { get; set; }

        public ICollection<string> AllCategoriesNames { get; set; }
    }
}