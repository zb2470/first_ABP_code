using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace first_abp_02.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : first_abp_02ControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}