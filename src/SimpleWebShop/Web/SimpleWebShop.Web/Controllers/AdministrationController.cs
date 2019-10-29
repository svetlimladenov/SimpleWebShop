using System.Web.Mvc;
using SimpleWebShop.Common;

namespace SimpleWebShop.Web.Controllers
{
    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    public class AdministrationBaseController :  BaseController
    {
    }
}