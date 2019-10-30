using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SimpleWebShop.Web.Infrastructure.Filters
{
    public class AutoValidateAntiforgeryTokenAttribute : IFilterProvider
    {
        public IEnumerable<Filter> GetFilters(ControllerContext controllerContext, ActionDescriptor actionDescriptor)
        {
            //take all filters  
            IEnumerable<FilterAttribute> filters = actionDescriptor.GetFilterAttributes(true);

            //check if there is an disableAntiForgeryFilter
            bool disableAntiForgery = filters.Any(f => f is DisableAntiForgeryCheckAttribute);

            //gets the method
            string method = controllerContext.HttpContext.Request.HttpMethod;

            //if there is no disableAntiForgeryFilter and the method is POST
            if (!disableAntiForgery
                && String.Equals(method, "POST", StringComparison.OrdinalIgnoreCase))
            {
                yield return new Filter(new ValidateAntiForgeryTokenAttribute(), FilterScope.Global, null);
            }
        }
    }

    [AttributeUsage(AttributeTargets.Method)]
    public sealed class DisableAntiForgeryCheckAttribute : FilterAttribute
    {
    }
}