using Microsoft.AspNetCore.Mvc;

namespace BSHospital.WebSite.Areas.Admin.Controllers
{
   
    public class DashboardController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
