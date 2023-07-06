using EnergyCollab.Web.Models;
using EnergyCollab.Web.Service.IService;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EnergyCollab.Web.Controllers
{
    public class CandidateProfileController : Controller
    {
        private readonly ICandidateProfileService _candidateProfileService;
        public CandidateProfileController(ICandidateProfileService candidateProfileService)
        {
            _candidateProfileService = candidateProfileService;
        }

        public async Task<IActionResult> CandidateProfileIndex()
        {
            List<CandidateProfileDto>? list = new();

            ResponseDto? response = await _candidateProfileService.GetAllCandidatesAsync();

            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<CandidateProfileDto>>(Convert.ToString(response.Result));
            }
            else
            {
                TempData["error"] = response?.Message;
            }

            return View(list);
        }
    }
}
