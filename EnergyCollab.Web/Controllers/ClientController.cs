using EnergyCollab.Web.Models;
using EnergyCollab.Web.Service;
using EnergyCollab.Web.Service.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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
            clientDto.Plan = clientPlan;
            ResponseDto? response = await _signUpService.CreateClientAccount(clientDto);
            if (response != null && response.IsSuccess)
            {
                var result = response.Result;
            }
            else
            {
                TempData["error"] = response?.Message;
            }
            return RedirectToAction("Login", "Signup");
        }

        [HttpGet]
        public async Task<IActionResult> ClientTabs( string tabId)
        {
            List<string> companies =  new List<string>();
            ViewData["DetailTabView"] = companies;
            companies.Add("Google");
            companies.Add("Optimal");
            if (tabId == "1")
            {
                //ResponseDto? response = await _signUpService.CreateClientAccount(companies);

                companies.Add("Google");
                companies.Add("Optimal");
                ViewData["DetailTabView"] = companies;
                return View("~/Views/Shared/_ClientDetailTabListView.cshtml", companies);
                // render company list template
                // on edit render a new partial page with three tab

            }
            else if(tabId == "2") 
            {
                 // render usergroup with 
            }
            return View("~/Views/SignUp/Login.cshtml");
        }
    }
}
