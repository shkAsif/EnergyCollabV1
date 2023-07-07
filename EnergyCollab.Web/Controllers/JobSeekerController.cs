using EnergyCollab.Web.Models;
using EnergyCollab.Web.Service;
using EnergyCollab.Web.Service.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace EnergyCollab.Web.Controllers
{
    public class JobSeekerController : Controller
    {
        private readonly IJobSearch _jobSearchService;
        public JobSeekerController(IJobSearch jobSearch)
        {
            _jobSearchService = jobSearch;
        }

        [HttpGet]
        public async Task<IActionResult> QuickJobSearch()
        {
            ResponseDto? response = await _jobSearchService.Country();

            if (response != null && response.IsSuccess)
            {

                var result = response.Result;
                List<CountryDto> countries = JsonConvert.DeserializeObject<List<CountryDto>>(Convert.ToString(response.Result));
                var countrySelectList = countries.Select(c => new SelectListItem
                {
                    Value = c.City.ToString(),
                    Text = c.Name
                }).ToList();
                ViewData["Countries"] = countrySelectList;
                return View();
            }
            else
            {
                TempData["error"] = response?.Message;
            }

            return View();

        }
    }
}
