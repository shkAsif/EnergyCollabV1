using AutoMapper;
using EnergyCollab.API.Data;
using EnergyCollab.API.Dto;
using EnergyCollab.Services.API.Dto;
using EnergyCollab.Services.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

    }
}
