﻿using System.Web.Mvc;
using SimpleWebShop.Services.Data.Contracts;
using SimpleWebShop.Web.Areas.Administration.ViewModels;
using SimpleWebShop.Web.Controllers;

namespace SimpleWebShop.Web.Areas.Administration.Controllers
{
    public class DashboardController : AdministrationBaseController
    {
        private readonly IProductsControlPanelServices productsControlPanelServices;

        public DashboardController(IProductsControlPanelServices productsControlPanelServices)
        {
            this.productsControlPanelServices = productsControlPanelServices;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductsControlPanel()
        {
            var viewModel = new ProductsControlViewModel()
            {
                CategoriesCount = this.productsControlPanelServices.GetAllCategoriesCount(),
                ProductsCount = this.productsControlPanelServices.GetAllProductsCount()
            };

            return this.View(viewModel);
        }
    }
}