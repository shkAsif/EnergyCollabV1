using Microsoft.AspNetCore.Mvc;

namespace EnergyCollab.Web.Controllers
{
    public class ClientController : Controller
    {
        [HttpGet]
        public IActionResult ClientSignUpPage(string id)
        {

            return View();
            //return View("~/Views/Home/ClientSignUp.)
        }


    }
}
