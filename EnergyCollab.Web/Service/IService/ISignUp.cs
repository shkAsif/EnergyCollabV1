using EnergyCollab.Web.Models;

namespace EnergyCollab.Web.Service.IService
{
    public interface ISignUp
    {
        
        Task<ResponseDto?> CreateUserSignUp(SignUpDto signUp);
       
    }
}
