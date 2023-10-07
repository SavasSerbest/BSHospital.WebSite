using Microsoft.AspNetCore.Mvc;

namespace BSHospital.WebSite.Areas.Admin.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
