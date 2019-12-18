using System;
using System.Collections.Generic;
using AutoMapper;
using SimpleWebShop.Data.Models;
using SimpleWebShop.Services.Mapping;

namespace SimpleWebShop.Web.Areas.Administration.ViewModels
{
    public class CreateProductInputModel : IMapTo<Product>
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Color { get; set; }

        public string Size { get; set; }

        public double Weight { get; set; }

        public string Description { get; set; }

        // public ICollection<ProductImage> ProductImages { get; set; }

        public int ProductsOnStock { get; set; }

        public string ProductCategoryName { get; set; }

        public ICollection<string> AllCategoriesNames { get; set; }
    }
}