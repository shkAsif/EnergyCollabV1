using AutoMapper;
using EnergyCollab.API.Data;
using EnergyCollab.API.Dto;
using EnergyCollab.Models;
using EnergyCollab.Services.API.Dto;
using EnergyCollab.Services.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace EnergyCollab.Services.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserGroupController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;


        public UserGroupController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new ResponseDto();
        }


        [Route("create")]
        [HttpPost]
        public async Task<IActionResult> CreateUserGroup([FromBody] UserGroupDto userGroupDto)
        {
            try
            {
                var userGroup = _mapper.Map<UserGroup>(userGroupDto);
                _db.UserGroups.Update(userGroup);
                _db.SaveChanges();
                _response.Result = _mapper.Map<UserGroupDtov2>(userGroup);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
                return BadRequest(_response.Message);
            }            
        }
    }
}

