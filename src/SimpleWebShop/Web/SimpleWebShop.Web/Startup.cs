using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleWebShop.Web.Startup))]
namespace SimpleWebShop.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
