﻿using BSHospital.Repository.Shared.Abstract;
using BSHospitalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSHospital.WebSite.Controllers
{
    public class DoctorController : ControllerBase
    {
        public DoctorController(IUnitOfWork unitOfWork):base(unitOfWork) 
        {

        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Doctor doctor)
        {
            unitOfWork.Doctors.Add(doctor);
            unitOfWork.Save();
            return View();
        }

        public IActionResult GetAll()
        {
            return Json(new {data=unitOfWork.Doctors.GetAll().ToList()});
        }

        [HttpPost]
        public IActionResult DeleteById(int id)//???? id isminde değişiklik olabilir.
        {
            unitOfWork.Doctors.DeleteById(id);
            unitOfWork.Save();
            return Ok("Başarıyla silindi");
        }

        [HttpPost]
        public IActionResult Update(Doctor doctor)
        {
            unitOfWork.Doctors.Update(doctor);
            unitOfWork.Save();
            return Ok();
        }
    }
}
