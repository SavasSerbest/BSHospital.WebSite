using BSHospital.WebSite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BSHospital.WebSite.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}