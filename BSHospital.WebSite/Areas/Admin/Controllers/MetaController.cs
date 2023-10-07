using Microsoft.AspNetCore.Mvc;

namespace BSHospital.WebSite.Areas.Admin.Controllers
{
    public class MetaController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
