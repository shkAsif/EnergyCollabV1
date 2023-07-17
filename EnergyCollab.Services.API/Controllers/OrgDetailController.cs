using AutoMapper;
using EnergyCollab.API.Data;
using EnergyCollab.API.Dto;
using EnergyCollab.Models;
using EnergyCollab.Services.API.Dto;
using EnergyCollab.Services.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace EnergyCollab.Services.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrgDetailController : ControllerBase
    {

        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;

        public OrgDetailController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new ResponseDto();
        }

        [Route("addorg")]
        [HttpPost]
        public async Task<IActionResult> SaveOrgDetails([FromBody] OrgDetailDto orgDetailsDto)
        {
            try
            {
                OrgDetail orgDetail = _mapper.Map<OrgDetail>(orgDetailsDto);
                _db.OrgDetails.Update(orgDetail);
                _db.SaveChanges();
                _response.Result = _mapper.Map<OrgDetailDto>(orgDetail);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return Ok(_response);
        }
    }
}
