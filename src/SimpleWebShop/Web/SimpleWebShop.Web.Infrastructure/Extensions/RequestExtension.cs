using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SimpleWebShop.Web.Infrastructure.Extensions
{
    public static class RequestExtension
    {
        public static bool IsHomePageRequest(this HttpRequestBase request)
        {
            if (request.Path == "/")
            {
                return true;
            }

            return false;
        }
    }
}
