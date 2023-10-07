using Microsoft.AspNetCore.Mvc;

namespace BSHospital.WebSite.Areas.Admin.Controllers
{
    public class PictureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
