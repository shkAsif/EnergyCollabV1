using AutoMapper;
using EnergyCollab.API.Data;
using EnergyCollab.API.Dto;
using EnergyCollab.Models;
using EnergyCollab.Services.API.Dto;
using EnergyCollab.Services.API.Models;
using Microsoft.AspNetCore.Mvc;
namespace EnergyCollab.Services.API.Controllers
{
    [Route("api/country")]
    public class CountryController : Controller
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private readonly IMapper _mapper;
        public CountryController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new ResponseDto();
        }
        [HttpGet]
        [Route("GetCountries")]
        public ResponseDto GetCountries()
        {
            try
            {
                IEnumerable<Country> country = _db.Countries.ToList();
                _response.Result = _mapper.Map<IEnumerable<CountryDto>>(country);
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
