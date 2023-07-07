using EnergyCollab.Web.Models;
using EnergyCollab.Web.Service;
using EnergyCollab.Web.Service.IService;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EnergyCollab.Web.Controllers
{
    public class ClientController : Controller
    {
        private readonly ISignUp _signUpService;
        public ClientController(ISignUp signUpService)
        {
            _signUpService = signUpService;
        }


        [HttpGet]
        public IActionResult ClientSignUpPage(string plan)
        {
            TempData["plan"]  = plan.Trim();
                return View();
            //return View("~/Views/Home/ClientSignUp.)
        }


        [HttpPost]
        public async Task<IActionResult> ClientSignUpPage(ClientSignUpDto clientDto)
        {
            string clientPlan = TempData["plan"].ToString();
            TempData.Keep("plan");
            ResponseDto? response = await _signUpService.CreateClientAccount(clientDto, clientPlan);

            if (response != null && response.IsSuccess)
            {
                var result = response.Result;
            }
            else
            {
                TempData["error"] = response?.Message;
            }

            return View();
        }

    }
}
