using Microsoft.AspNetCore.Mvc;

namespace BSHospital.WebSite.Areas.Admin.Controllers
{
    public class ContactFormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
