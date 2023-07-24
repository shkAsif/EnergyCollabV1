using EnergyCollab.Web.Models;
using EnergyCollab.Web.Service.IService;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EnergyCollab.Web.Controllers
{
    public class SignUpController : Controller
    {
        private readonly ISignUp _signUpService;
        public SignUpController(ISignUp signUpService)
        {
            _signUpService = signUpService;
        }
        [HttpGet]
        public ActionResult CreateSignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateSignUp(SignUpDto signUpDto)
        {
            ResponseDto? response = await _signUpService.CreateUserSignUp(signUpDto);
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
        public ActionResult Login()
        {
            ViewData["error"] = "none";

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDto UserLogin)
        {
            ViewData["error"] = "none";
            ResponseDto? response = await _signUpService.UserLogin(UserLogin);
            if (response != null && response.IsSuccess && response.Result !=null && response.Result != "")
            {
                var result = response.Result;
                if (UserLogin.EmailId.Contains("anil"))
                {
                    //return RedirectToAction("CreateSignUp", "Signup");
                    ResponseDto? responseOrg = await _signUpService.GetOrgShortSummary();

                    List<OrganizationDto> organizationsShortSummry = JsonConvert.DeserializeObject<List<OrganizationDto>>(Convert.ToString(responseOrg.Result));
                    ViewData["Companies"] = organizationsShortSummry;
                    return View("~/Views/Client/ClientDashboard.cshtml");
                }
                return View("~/Views/SignUp/UserLoggedIn.cshtml");
            }
            else
            {
                ViewData["error"] = "block";
            }
            return View();
        }
    }
}
