using AutoMapper;
using EnergyCollab.API.Data;
using EnergyCollab.API.Dto;
using EnergyCollab.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace EnergyCollab.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateProfileController : ControllerBase
    {

        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;

        public CandidateProfileController(AppDbContext db, IMapper mapper)
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
                IEnumerable<CandidateProfile> candidateProfiles = _db.CandidateProfiles.ToList();
                _response.Result = _mapper.Map<IEnumerable<CandidateProfileDto>>(candidateProfiles);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ResponseDto Get(int id)
        {
            try
            {
                CandidateProfile obj = _db.CandidateProfiles.First(u => u.Id == id);
                _response.Result = _mapper.Map<CandidateProfileDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("GetByCode/{code}")]
        public ResponseDto GetByCode(Guid code)
        {
            try
            {
                CandidateProfile obj = _db.CandidateProfiles.First(u => u.UserAccountId == code);
                _response.Result = _mapper.Map<CandidateProfileDto>(obj);
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
        public ResponseDto Post([FromBody] CandidateProfileDto candidateProfileDto)
        {
            try
            {
                CandidateProfile obj = _mapper.Map<CandidateProfile>(candidateProfileDto);
                _db.CandidateProfiles.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<CandidateProfileDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPut]
        //[Authorize(Roles = "ADMIN")]
        public ResponseDto Put([FromBody] CandidateProfileDto candidateProfileDto)
        {
            try
            {
                CandidateProfile obj = _mapper.Map<CandidateProfile>(candidateProfileDto);
                _db.CandidateProfiles.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<CandidateProfileDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpDelete]
        [Route("{id:int}")]
        //[Authorize(Roles = "ADMIN")]
        public ResponseDto Delete(int id)
        {
            try
            {
                CandidateProfile obj = _db.CandidateProfiles.First(u => u.Id == id);
                _db.CandidateProfiles.Remove(obj);
                _db.SaveChanges();
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
