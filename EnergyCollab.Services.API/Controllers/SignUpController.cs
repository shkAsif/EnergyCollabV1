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
                SignUp obj =  _mapper.Map<SignUp>(signUpDto);
                _db.SignUps.Add(obj);
                _db.SaveChanges();
                _response.Result = _mapper.Map<SignUpDto>(obj);

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
                Login loginObj = _mapper.Map<Login>(loginDto);
                //_db.Logins.Add(loginObj);
                //_db.SaveChanges();
                //_response.Result = _mapper.Map<LoginDto>(loginObj);


                var users = await _db.SignUps
                   .AsNoTracking()
                   .Where(x => x.Email.ToLower().Equals(loginObj.EmailId.ToLower())
                           && x.Password.ToLower().Equals(loginObj.Password.ToLower()))
                   .ToListAsync();

                _response.Result = _mapper.Map<SignUpDto>(users);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
                return BadRequest( _response);
            }
           
        }
    }
}
