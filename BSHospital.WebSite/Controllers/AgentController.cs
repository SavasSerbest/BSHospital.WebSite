using BSHospital.Repository.Shared.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BSHospital.WebSite.Controllers
{
    public class AgentController : ControllerBase
    {
        public AgentController(IUnitOfWork unitOfWork):base(unitOfWork) 
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
