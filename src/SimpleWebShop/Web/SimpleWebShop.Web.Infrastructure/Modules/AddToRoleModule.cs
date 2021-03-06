﻿using System.Web;

namespace SimpleWebShop.Web.Infrastructure.Modules
{
    public class AddToRoleModule : IHttpModule
    {
        public void Init(HttpApplication app)
        {
            app.BeginRequest += (sender, args) =>
            {
                var context = HttpContext.Current;
                if (context.Request.HttpMethod == "POST" && context.Request.RawUrl == "/Account/Register")
                {
                    // add to role
                }
            };
        }

        public void Dispose()
        {
            //do nothing
        }
    }
}