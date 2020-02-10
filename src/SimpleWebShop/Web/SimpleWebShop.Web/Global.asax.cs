using System.Data.Entity;
using System.Reflection;
using SimpleWebShop.Data;
using SimpleWebShop.Data.Migrations;
using SimpleWebShop.Services.Models.ViewModels.Home;
using SimpleWebShop.Web.Areas.Administration.ViewModels;

namespace SimpleWebShop.Web
{
    using SimpleWebShop.Services.Mapping;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //add view engine config
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //AutoMapperConfig.RegisterMappings(typeof(HomeIndexViewModel).Assembly,typeof(CreateCategoryDTO).Assembly,Assembly.GetExecutingAssembly());
        }
    }
}
