using EnergyCollab.Web.Models;

namespace EnergyCollab.Web.Service.IService
{
    public interface IJobSeeker
    {
        
        Task<ResponseDto?> CreateJobSeeker(JobSeekerLogin jobseeker);
       
    }
}
