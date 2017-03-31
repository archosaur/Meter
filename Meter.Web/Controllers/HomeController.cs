using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Meter.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MeterControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}