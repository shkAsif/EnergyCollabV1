﻿using AutoMapper;
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
    [Route("api/signup")]
    public class SignUpController : Controller
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;
        public SignUpController(AppDbContext db, IMapper mapper)
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
                IEnumerable<SignUp> signUps = _db.SignUps.ToList();
                _response.Result = _mapper.Map<IEnumerable<SignUpDto>>(signUps);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }
        [HttpPost]
        //[Authorize(Roles = "ADMIN")]
        public async Task<IActionResult> Post([FromBody] SignUpDto signUpDto)
        {
            try
            {
                //signUpDto.fileDetailDto.FileData = new byte[0];
                SignUp signUp = _mapper.Map<SignUp>(signUpDto);
                await _db.SignUps.AddAsync(signUp);
                await _db.SaveChangesAsync();
                _response.Result = _mapper.Map<SignUpDto>(signUp);

                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
                return BadRequest(_response);
            }

        }



        [HttpPost]
        [Route("login")]
        //[Authorize(Roles = "ADMIN")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            try
            {
                var users = await _db.SignUps
                   .AsNoTracking()
                   .Include(x => x.CandidateProfile)
                   .Where(x => x.Email.ToLower().Equals(loginDto.EmailId.ToLower())
                           && x.Password.ToLower().Equals(loginDto.Password.ToLower()))
                   .FirstOrDefaultAsync();

                _response.Result = _mapper.Map<SignUpDto>(users);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
                return BadRequest(_response);
            }

        }
    }
}
