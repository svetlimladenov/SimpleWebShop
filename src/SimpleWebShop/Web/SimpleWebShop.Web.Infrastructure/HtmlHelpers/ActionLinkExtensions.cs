using System;
using System.Web;
using System.Web.Mvc;

namespace SimpleWebShop.Web.Infrastructure.HtmlHelpers
{
    public static class ActionLinkExtensions
    {
        public static IHtmlString ActionLinkFontAwesomeWithHeading(this HtmlHelper helper, string action, string controller, string area ,string fontAwesomeClasses, string linkTitle)
        {
            var result = "";
            if (area == null)
            {
                result =
                    String.Format(
                        $"<a href=\"https://localhost:44333/{controller}/{action}\"><i class=\"{fontAwesomeClasses}\"></i><h4>{linkTitle}</h4></a>");
            }
            else
            {
                result =
                    String.Format(
                        $"<a href=\"https://localhost:44333/{area}/{controller}/{action}\"><i class=\"{fontAwesomeClasses}\"></i><h4>{linkTitle}</h4></a>");
            }

            return new HtmlString(result);
        }

        public static IHtmlString ActionLinkFontAwesome(this HtmlHelper helper, string action, string controller, string area, string fontAwesomeClasses, string linkTitle)
        {
            var result = "";
            if (area == null)
            {
                result =
                    String.Format(
                        $"<a href=\"https://localhost:44333/{controller}/{action}\"><i class=\"{fontAwesomeClasses}\"></i>{linkTitle}</a>");
            }
            else
            {
                result =
                    String.Format(
                        $"<a href=\"https://localhost:44333/{area}/{controller}/{action}\"><i class=\"{fontAwesomeClasses}\"></i>{linkTitle}</a>");
            }

            return new HtmlString(result);
        }
    }
}
