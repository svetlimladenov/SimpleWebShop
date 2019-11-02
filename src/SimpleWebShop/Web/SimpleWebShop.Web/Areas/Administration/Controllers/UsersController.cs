﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleWebShop.Web.Services.Contracts;

namespace SimpleWebShop.Web.Areas.Administration.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersServices usersServices;

        public UsersController(IUsersServices usersServices)
        {
            this.usersServices = usersServices;
        }
        // GET: Administration/Users
        public ActionResult Index()
        {
            //return all users 
            //TODO: Create certain pages for admins and deleted users
            var viewModel = this.usersServices.GetAllUsers();
            return View(viewModel);
        }
    }
}