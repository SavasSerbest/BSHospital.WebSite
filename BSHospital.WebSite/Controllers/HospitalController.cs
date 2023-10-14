using BSHospital.Repository.Shared.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BSHospital.WebSite.Controllers
{
    public class HospitalController : ControllerBase
    {
        public HospitalController(IUnitOfWork unitOfWork):base(unitOfWork)
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
