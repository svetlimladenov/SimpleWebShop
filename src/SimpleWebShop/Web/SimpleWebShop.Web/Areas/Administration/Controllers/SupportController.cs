﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleWebShop.Web.Controllers;

namespace SimpleWebShop.Web.Areas.Administration.Controllers
{
    public class SupportController : AdministrationBaseController
    {
        public ActionResult Index()
        {
            return this.View();
        }
    }
}