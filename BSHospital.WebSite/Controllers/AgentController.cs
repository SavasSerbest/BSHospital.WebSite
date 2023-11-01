using BSHospital.Data;
using BSHospital.Repository.Shared.Abstract;
using BSHospitalProject.Models;
using BSHospitalProject.Models.Agents;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace BSHospital.WebSite.Controllers
{
    public class AgentController : ControllerBase
    {
        
        public AgentController(IUnitOfWork unitOfWork):base(unitOfWork) 
        {
            
        }
        public IActionResult Index(int agetnID)
        {
           


            return View(unitOfWork.AgentLogins.GetAll(a=>a.Id==agetnID).ToList());
            
        }

        
        public IActionResult GetAll()
        {
            return Json(new {data= unitOfWork.AgentLogins.GetAll().Select(a=> new {

                a.Name
            }) });
        }
    }
}


