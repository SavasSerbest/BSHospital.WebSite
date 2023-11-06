using BSHospital.Repository.Shared.Abstract;
using BSHospitalProject.Models;
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

        [HttpPost]
        public IActionResult Add(Appointment appointment)
        {
            unitOfWork.Appointments.Add(appointment);
            unitOfWork.Save();
            return View();
        }

        public IActionResult GetAll() 
        {
            return Json(new {data= unitOfWork.Appointments.GetAll().ToList()});
        }

        [HttpPost]
        public IActionResult DeleteById(int id) 
        {
            unitOfWork.Appointments.DeleteById(id);
            unitOfWork.Save();
            return Ok("Başarıyla silindi");
        }

        [HttpPost]
        public IActionResult Update(Appointment appointment)
        {
            unitOfWork.Appointments.Update(appointment);
            unitOfWork.Save();
            return Ok();
        }
    }
}
