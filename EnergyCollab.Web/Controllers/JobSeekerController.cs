using EnergyCollab.Web.Models;
using EnergyCollab.Web.Service;
using EnergyCollab.Web.Service.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Build.Evaluation;
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
        public async Task<IActionResult> QuickJobSearch(QuickJobSearch quickjobData)
        {
            ResponseDto? response = await _jobSearchService.Country();
            ResponseDto? JobResult = await _jobSearchService.SearchJob();
            if (response != null && response.IsSuccess)
            {
                List<CountryDto> countries = JsonConvert.DeserializeObject<List<CountryDto>>(Convert.ToString(response.Result));
                List<VacancyDto> vacancies = JsonConvert.DeserializeObject<List<VacancyDto>>(Convert.ToString(JobResult.Result));
                var countrySelectList = countries.Select(c => new SelectListItem
                {
                    Value = c.CountryCode,
                    Text = c.Name
                }).ToList();
                ViewData["Countries"] = countrySelectList;
                ViewData["vacancies"] = vacancies;
            }
            else
            {
                TempData["error"] = response?.Message;
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> FilterQuickJobSearch([FromBody] QuickJobSearch searchfilterata)
        {
            List<VacancyDto> vacancies = new List<VacancyDto>();
            ResponseDto? response = await _jobSearchService.FilterBasicSearchJob(searchfilterata);
            if (response != null && response.IsSuccess)
            {
                vacancies = JsonConvert.DeserializeObject<List<VacancyDto>>(Convert.ToString(response.Result));
                ViewData["vacancies"] = vacancies;
            }
            else
            {
                TempData["error"] = response?.Message;
            }
            //return View();
            return PartialView("~/Views/Shared/Vacancies.cshtml", vacancies);
        }
        [HttpGet]
        public async Task<IActionResult> CompleteSearchVacancies(string country,
            string IndustryEnpeience,
            string EmploymentCategory,
            string Education,
            string SalaryAmount,
            string SalaryCurrency,
            string ExperienceCategory,
            string OrderBy)
        {
            var a = country;
            if (!String.IsNullOrEmpty(country))
            {
                ResponseDto? response = await _jobSearchService.Country();
                ResponseDto? JobResult = await _jobSearchService.SearchJob();
                if (response != null && response.IsSuccess)
                {
                    List<CountryDto> countries = JsonConvert.DeserializeObject<List<CountryDto>>(Convert.ToString(response.Result));
                    List<VacancyDto> vacancies = JsonConvert.DeserializeObject<List<VacancyDto>>(Convert.ToString(JobResult.Result));
                    var countrySelectList = countries.Select(c => new SelectListItem
                    {
                        Value = c.City.ToString(),
                        Text = c.Name
                    }).ToList();
                    ViewData["Countries"] = countrySelectList;
                    ViewData["vacancies"] = vacancies;
                }
                else
                {
                    TempData["error"] = response?.Message;
                }
                return View("~/Views/JobSeeker/JobSeekerSearchVacancies.cshtml");
            }
            else
            {
                return View("~/Views/JobSeeker/JobSeekerSearchVacancies.cshtml");
            }
        }
    }
}
