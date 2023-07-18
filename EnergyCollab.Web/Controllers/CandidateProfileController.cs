using EnergyCollab.Web.Models;
using EnergyCollab.Web.Service;
using EnergyCollab.Web.Service.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
namespace EnergyCollab.Web.Controllers
{
    public class CandidateProfileController : Controller
    {
        private readonly ICandidateProfileService _candidateProfileService;
		private readonly IJobSearch _search;

		public CandidateProfileController(ICandidateProfileService candidateProfileService , IJobSearch search)
        {
            _candidateProfileService = candidateProfileService;
            _search = search;
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

        [HttpGet]
        public async Task<IActionResult> CandidateDetailProfile(int id)
        {
			ResponseDto? countriesList = await _search.Country();
			CandidateProfileDto candidateProfileDetails = new();
            ResponseDto? response = await _candidateProfileService.GetCandidateByIdAsync(id);
            if (response != null && response.IsSuccess)
            {
				List<CountryDto> countries = JsonConvert.DeserializeObject<List<CountryDto>>(Convert.ToString(countriesList.Result));

				candidateProfileDetails = JsonConvert.DeserializeObject<CandidateProfileDto>(Convert.ToString(response.Result));
                var countrySelectList = countries.Select(c => new SelectListItem
                {
                    Value = c.CountryCode,
                    Text = c.Name
                }).ToList();
                ViewData["countries"] = countrySelectList;

			}
            else
            {
                TempData["error"] = response?.Message;
            }
            return View("~/Views/JobSeeker/jobSeekerProfile.cshtml", candidateProfileDetails);
        }
    }
}
