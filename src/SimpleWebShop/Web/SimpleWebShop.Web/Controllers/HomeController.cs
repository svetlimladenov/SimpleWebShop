using System;
using Microsoft.AspNet.Identity.EntityFramework;
using SimpleWebShop.Data;
using SimpleWebShop.Data.Common;
using SimpleWebShop.Data.Models;

namespace SimpleWebShop.Web.Controllers
{
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }
    }
}