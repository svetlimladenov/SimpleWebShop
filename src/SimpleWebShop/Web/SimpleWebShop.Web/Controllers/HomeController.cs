using System;
using SimpleWebShop.Data;
using SimpleWebShop.Data.Common;
using SimpleWebShop.Data.Models;

namespace SimpleWebShop.Web.Controllers
{
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        private readonly IDbRepository<Product> products;

        public HomeController(IDbRepository<Product> products)
        {
            this.products = products;
        }
        public ActionResult Index()
        {
            var product = this.products.GetById("486d3ecc-fdd1-416a-881c-c26dc4826390");
            return this.View(product);
        }
    }
}