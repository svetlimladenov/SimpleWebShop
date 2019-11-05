using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleWebShop.Web.Areas.Administration.ViewModels;
using SimpleWebShop.Web.Controllers;

namespace SimpleWebShop.Web.Areas.Administration.Controllers
{
    public class CategoriesAdministrationController : AdministrationBaseController
    {
        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //TODO: AutoValidateAntiForgeryToken
        public ActionResult Create(CreateCategoryInputModel inputModel)
        {
            if (!ModelState.IsValid)
            {
                return this.View();
            }

            return this.RedirectToAction("ProductsControlPanel" ,"Dashboard");
        }
    }
}