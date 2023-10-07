using Microsoft.AspNetCore.Mvc;

namespace BSHospital.WebSite.Areas.Admin.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
