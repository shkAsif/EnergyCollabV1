using EnergyCollab.Web.Models;
using EnergyCollab.Web.Service;
using EnergyCollab.Web.Service.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Drawing.Drawing2D;
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
            TempData["plan"] = plan.Trim();
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
        public async Task<IActionResult> ClientTabs(string tabId)
        {
            List<string> companies = new List<string>();
            List<string> userGroups = new List<string>();
            List<string> securityRights = new List<string>();
            List<string> templates = new List<string>();
            List<string> candidateSubscribers = new List<string>();

            companies.Add("Optimal");
            companies.Add("Google");
            ViewData["Companies"] = companies;
            if (tabId == "1")
            {
                //ResponseDto? response = await _signUpService.CreateClientAccount(companies);

                companies.Add("Google");
                companies.Add("Optimal");
                ViewData["Companies"] = companies;
                return View("~/Views/Shared/_ClientDetailTabListView.cshtml", companies);

            }
            else if (tabId == "2")
            {
                userGroups.Add("OptimalGroup");
                userGroups.Add("EnergyCollabGroup");
                ViewData["UserGroups"] = userGroups;
                return View("~/Views/Shared/_PartialUserGroups.cshtml", userGroups);
            }
            else if (tabId == "3")
            {
                securityRights.Add("OptimalGroup");
                userGroups.Add("EnergyCollabGroup");
                ViewData["SecurityRights"] = securityRights;
                return View("~/Views/Shared/_PartialSecurityRights.cshtml", securityRights);
            }
            else if (tabId == "4")
            {
                templates.Add("OptimalGroup");
                templates.Add("EnergyCollabGroup");
                ViewData["Templates"] = templates;
                return View("~/Views/Shared/_PartialTemplates.cshtml", templates);
            }
            else if (tabId == "5")
            {
                candidateSubscribers.Add("OptimalGroup");
                candidateSubscribers.Add("EnergyCollabGroup"); 
                ViewData["CandidateSubscribers"] = candidateSubscribers;
                return View("~/Views/Shared/_PartialCandidteSubscriber.cshtml", candidateSubscribers);
            }
            return View("~/Views/SignUp/Login.cshtml");
        }
    }
}
