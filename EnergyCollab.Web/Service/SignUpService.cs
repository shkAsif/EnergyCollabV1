using EnergyCollab.Web.Models;
using EnergyCollab.Web.Service.IService;
using EnergyCollab.Web.Utility;

namespace EnergyCollab.Web.Service
{
    public class SignUpService : ISignUp
    {
        private readonly IBaseService _baseService;
        public SignUpService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        

        public async Task<ResponseDto?> CreateUserSignUp(SignUpDto signUpDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = signUpDto,
                Url = SD.CandidateAPIBase + "/api/SignUp"
            });
        }
    }
}
