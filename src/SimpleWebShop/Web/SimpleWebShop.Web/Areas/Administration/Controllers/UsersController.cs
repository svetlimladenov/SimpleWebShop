﻿using System.Web.Mvc;
using SimpleWebShop.Web.Areas.Administration.Services;
using SimpleWebShop.Web.Controllers;

namespace SimpleWebShop.Web.Areas.Administration.Controllers
{
    public class UsersController : AdministrationBaseController
    {
        private readonly IUsersServices usersServices;

        public UsersController(IUsersServices usersServices)
        {
            this.usersServices = usersServices;
        }
        // GET: Administration/Users
        public ActionResult Index()
        {
            //TODO: Create certain pages for admins and deleted users
            var viewModel = this.usersServices.GetAllUsers();
            return View(viewModel);
        }
    }
}