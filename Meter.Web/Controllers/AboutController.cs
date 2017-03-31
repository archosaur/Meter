using System.Web.Mvc;

namespace Meter.Web.Controllers
{
    public class AboutController : MeterControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}