namespace SimpleWebShop.Web
{
    using System.Web.Mvc;
    using SimpleWebShop.Web.Infrastructure.Filters;

    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            FilterProviders.Providers.Add(new AutoValidateAntiforgeryTokenAttribute());
        }
    }
}
