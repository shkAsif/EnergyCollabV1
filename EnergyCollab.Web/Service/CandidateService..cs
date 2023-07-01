using EnergyCollab.Web.Models;
using EnergyCollab.Web.Service.IService;
using EnergyCollab.Web.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCollab.Web.Service
{
    public class CandidateService : ICandidateProfileService
    {
        private readonly IBaseService _baseService;
        public CandidateService(IBaseService baseService)
        {
            _baseService = baseService;
        }


        public async Task<ResponseDto?> CreateCandidateAsync(CandidateProfileDto candidateProfileDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = candidateProfileDto,
                Url = SD.CandidateAPIBase + "/api/CandidateProfile"
            });
        }

        public async Task<ResponseDto?> DeleteCandidatesAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.CandidateAPIBase + "/api/candidateprofile/" + id
            });
        }

        public async Task<ResponseDto?> GetAllCandidatesAsync()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.CandidateAPIBase + "/api/candidateprofile"
            });
        }

        public async Task<ResponseDto?> GetCandidateAsync(string userAccountId)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.CandidateAPIBase + "/api/candidateprofile/GetByCode/" + userAccountId
            });
        }

        public async Task<ResponseDto?> GetCandidateByIdAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.CandidateAPIBase + "/api/candidateprofile/" + id
            });
        }

        public async Task<ResponseDto?> UpdateCandidatesAsync(CandidateProfileDto candidateProfileDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.PUT,
                Data = candidateProfileDto,
                Url = SD.CandidateAPIBase + "/api/candidateprofile"
            });
        }
    }
}
