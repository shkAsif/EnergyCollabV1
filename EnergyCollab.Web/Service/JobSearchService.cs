using EnergyCollab.Web.Models;
using EnergyCollab.Web.Service.IService;
using EnergyCollab.Web.Utility;

namespace EnergyCollab.Web.Service
{
    public class JobSearchService : IJobSearch
    {
        private readonly IBaseService _baseService;
        public JobSearchService(IBaseService baseService)
        {
            _baseService = baseService;
        }
        public async Task<ResponseDto?> Country()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,               
                Url = SD.CandidateAPIBase + "/api/country"
            });

        }
    }
}
