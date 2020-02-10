using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AutoMapper;
using SimpleWebShop.Data.Models;
using SimpleWebShop.Services.Mapping;

namespace SimpleWebShop.Web.Areas.Administration.ViewModels
{
    public class CreateCategoryViewModel
    {
        public List<string> AllFontAwesomeIcons { get; set; }

        public ICollection<string> AllCategoriesNames { get; set; }
    }
}