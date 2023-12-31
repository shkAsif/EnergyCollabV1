﻿using AutoMapper;
using EnergyCollab.API.Data;
using EnergyCollab.API.Dto;
using EnergyCollab.Services.API.Dto;
using EnergyCollab.Services.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
namespace EnergyCollab.Services.API.Controllers
{
    [Route("api/vacancy")]
    [ApiController]
    public class VacancyController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;
        public VacancyController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new ResponseDto();
        }
        [Route("GetAll")]
        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                IEnumerable<Vacancy> vacancies = _db.Vacancies
                    .AsNoTracking()
                    .Include(x => x.organization)
                    .Include(x => x.country)
                    .ToList();
                _response.Result = _mapper.Map<IEnumerable<VacancyDto>>(vacancies);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }
        [Route("search")]
        [HttpGet]
        public async Task<IActionResult> SearchVacancy(FilterQuickJobSearchDto quickjobData)
        {
            try
            {
                IEnumerable<Vacancy> vacancies = await _db.Vacancies
                    .AsNoTracking()
                    .Include(x => x.organization)
                    .Include(x => x.country)
                    .Where(x => x.country.CountryCode.ToLower().Equals(quickjobData.CountryCode.ToLower())
                            || x.JobTitle.ToLower().Equals(quickjobData.SearchPhrase.ToLower()))
                    .ToListAsync();
                _response.Result = _mapper.Map<IEnumerable<VacancyDto>>(vacancies);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
                return BadRequest();
            }
        }
        [Route("detailsearch")]
        [HttpPost]
        public async Task<IActionResult> DetailSearchVacany([FromBody]DetailSearchViewModel detailSearchViewModel)
        {
            try
            {
                IEnumerable<Vacancy> vacancies = await _db.Vacancies
                    .AsNoTracking()
                    .Include(x => x.organization)
                    .Include(x => x.country)
                    .Include(x => x.experience)
                    .Where(x =>
                               x.country.CountryCode.Equals(detailSearchViewModel.CountryCode)
                            || x.experience.Range.Equals(detailSearchViewModel.experience))
                    ///EmpCat,Salary, Educ, ExpCat
                    .OrderBy(x => x.country.Name)
                    .ToListAsync();
                _response.Result = _mapper.Map<IEnumerable<VacancyDto>>(vacancies);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
                return BadRequest();
            }
        }
    }
}
