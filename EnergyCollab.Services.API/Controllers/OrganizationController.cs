using AutoMapper;
using EnergyCollab.API.Data;
using EnergyCollab.API.Dto;
using EnergyCollab.Models;
using EnergyCollab.Services.API.Dto;
using EnergyCollab.Services.API.Models;
using EnergyCollab.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;


namespace EnergyCollab.Services.API.Controllers
{
    [Route("api/org")]
    [ApiController]
    public class OrganizationController : Controller
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;

        public OrganizationController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new ResponseDto();
        }

        [Route("GetAll")]
        [HttpGet]
        public async Task<IActionResult> GetAllOrgSummary()
        {
            try
            {
                IEnumerable<Organization> orgs = await _db.Organizations
                    .AsNoTracking()
                    .Include(x => x.OrgDetails)
                    .Include(x => x.country)                    
                    .OrderBy(x => x.Name)
                    .ToListAsync();
                _response.Result = _mapper.Map<IEnumerable<OrgSummaryDto>>(orgs);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
                return BadRequest();
            }
        }

        //[Route("Default/GetRecordsById/{id:int}")]
        [Route("getOrgDetialsById/{orgid:int}")]
        [HttpGet]
        public async Task<IActionResult> GetAllOrgSummary(int orgid)
        {
            try
            {
                OrgDetail? orgDetail = await _db.OrgDetails
                    .AsNoTracking()
                    .Include(x=> x.organization)
                    .Where(x => x.Id == orgid)                    
                    .FirstOrDefaultAsync();

                _response.Result = _mapper.Map<OrgDetailDto>(orgDetail);
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
