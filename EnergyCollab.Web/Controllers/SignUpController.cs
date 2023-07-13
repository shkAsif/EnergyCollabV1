using EnergyCollab.Web.Models;
using EnergyCollab.Web.Service.IService;
using Microsoft.AspNetCore.Mvc;
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
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDto UserLogin)
        {
            ResponseDto? response = await _signUpService.UserLogin(UserLogin);
            if (response != null && response.IsSuccess)
            {
                var result = response.Result;
                if (UserLogin.EmailId.Contains("client"))
                {
                    //return RedirectToAction("CreateSignUp", "Signup");
                    return View("~/Views/Client/ClientDashboard.cshtml");
                }
                return View("~/Views/SignUp/UserLoggedIn.cshtml");
            }
            else
            {
                TempData["error"] = response?.Message;
            }
            return View();
        }
    }
}
