using AutoMapper;
using EnergyCollab.API.Data;
using EnergyCollab.API.Dto;
using EnergyCollab.Models;
using EnergyCollab.Services.API.RepoService;
using EnergyCollab.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using static EnergyCollab.Services.API.HelperMethod.Helper;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace EnergyCollab.API.Controllers
{
    [Route("api/candidateprofile")]
    [ApiController]
    public class CandidateProfileController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;
        private readonly IFileService _uploadService;

        public CandidateProfileController(AppDbContext db, IMapper mapper, IFileService uploadService)
        {
            _db = db;
            _mapper = mapper;
            _response = new ResponseDto();
            _uploadService = uploadService;
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

                CandidateProfile obj = _db.CandidateProfiles.First(u => u.SignUpId == id);
                _response.Result = _mapper.Map<CandidateProfileDto>(obj);
                return _response;
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

        [HttpPut]
        [Route("UpdateProfile/{signUpId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutUpdateProfile([FromForm] CandidateProfileDtoV2 candidateProfileDtoV2, int signUpId, CancellationToken cancellationToken = default)
        {
            try
            {
                if (signUpId != 0)
                {
                    //Get Candidate detail
                    SignUp? signUp = await _db.SignUps
                        .Include(u => u.CandidateProfile)
                        .Include(f => f.FileDetail)
                        .Where(x => x.Id == signUpId)
                        .FirstOrDefaultAsync(cancellationToken);

                    //_mapper.Map<CandidateProfileDtoV2>(signUp);

                    if (signUp == null)
                    {
                        return NotFound(); // Return appropriate response if SignUp is not found
                    }

                    FileDetail fileDetails = new FileDetail()
                    {
                        FileName = candidateProfileDtoV2.fileUploadDto.FileDetails.FileName,
                        FileType = candidateProfileDtoV2.fileUploadDto.FileType
                    };

                    using (var stream = new MemoryStream())
                    {
                        candidateProfileDtoV2.fileUploadDto.FileDetails.CopyTo(stream);
                        fileDetails.FileData = stream.ToArray();
                    }

                    //TODO
                    //Update minimum field later for now add all files or use automapper
                    if (candidateProfileDtoV2 != null)
                    {
                        signUp.CandidateProfile.UserAccountId = candidateProfileDtoV2?.UserAccountId ?? Guid.NewGuid();
                        signUp.CandidateProfile.CountryCode = candidateProfileDtoV2?.CountryCode;
                        signUp.CandidateProfile.CityName = candidateProfileDtoV2?.CityName;


                        //SignUp updateSignUp = _mapper.Map<SignUp>(candidateProfileDtoV2);
                        //updateSignUp.Email = signUp.Email;
                        //updateSignUp.FirstName = signUp.FirstName;
                        //updateSignUp.LastName = signUp.LastName;
                        //updateSignUp.Password = signUp.Password;
                        //updateSignUp.ConfirmPassword = signUp.ConfirmPassword;
                        //updateSignUp.CompanyName = signUp.CompanyName;
                        //updateSignUp.LoginUser = signUp.LoginUser;


                        signUp.FileDetail.FileName = fileDetails.FileName;
                        signUp.FileDetail.FileType = fileDetails.FileType;
                        signUp.FileDetail.FileData = fileDetails.FileData;
                        _db.SignUps.Update(signUp);
                    }

                    //signUp.FileDetail.FileName = fileDetails.FileName;
                    //signUp.FileDetail.FileType = fileDetails.FileType;
                    //signUp.FileDetail.FileData = fileDetails.FileData;

                    //CandidateProfile obj = _mapper.Map<CandidateProfile>(candidateProfileDtoV2);
                    //_db.SignUps.Update(signUp);                    
                }
                _db.SaveChanges();
                //_response.Result = _mapper.Map<CandidateProfileDto>(obj);
                return Ok("Saved");
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
                return BadRequest(ex);
            }

        }


        [HttpGet]
        [Route("DownloadCV/{signUpId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DownloadCV(int signUpId)
        {
            if (signUpId < 1) return BadRequest();           

            try
            {
                await _uploadService.DownloadCVById(signUpId);
                return Ok();
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
                return BadRequest(ex);
            }            
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
