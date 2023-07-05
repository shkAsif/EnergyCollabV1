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
        public  ActionResult CreateSignUp()
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

            return View() ;
        }
    }
}
