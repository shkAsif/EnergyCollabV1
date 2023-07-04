using EnergyCollab.Web.Models;
using EnergyCollab.Web.Service.IService;
using EnergyCollab.Web.Utility;

namespace EnergyCollab.Web.Service
{
    public class JobSeeker : IJobSeeker
    {
        private readonly IBaseService _baseService;
        public JobSeeker(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto?> CreateJobSeeker(JobSeekerLogin jobseeker)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = jobseeker ,
                Url = SD.CandidateAPIBase + "/api/CandidateProfile"
            });
        }

      
    }
}
