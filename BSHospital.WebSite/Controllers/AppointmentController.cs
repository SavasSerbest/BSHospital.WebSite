using BSHospital.Repository.Shared.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BSHospital.WebSite.Controllers
{
    public class AppointmentController : ControllerBase
    {
        public AppointmentController(IUnitOfWork unitOfWork):base(unitOfWork)
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
