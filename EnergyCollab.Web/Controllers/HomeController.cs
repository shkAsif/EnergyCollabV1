using EnergyCollab.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EnergyCollab.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index(string id)
        {

            if (id == "JobSeekerLogin")
            {
                return RedirectToAction("Login", "Signup");
            }
            else if (id == "JobSeekerSignUp")
            {
                return RedirectToAction("CreateSignUp", "Signup");
            }
            else if (id == "guest")
            {
                return RedirectToAction("Index", "JobSeeker");
            }
            else if (id == "ClientLogin")
            {
                return View();
            }
            else if (id == "ClientSignUp")
            {
                //return RedirectToAction("ClientSignUpPage", "Client");
                return View("~/Views/Home/ClientSignUp.cshtml");
            }
            else
            {
                return View();
            }
            //return RedirectToAction("CreateSignUp", "Signup");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}