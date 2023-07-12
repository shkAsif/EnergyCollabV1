using EnergyCollab.Web.Models;
namespace EnergyCollab.Web.Service.IService
{
    public interface ICandidateProfileService
    {
        Task<ResponseDto?> GetCandidateAsync(string userAccountId);
        Task<ResponseDto?> GetAllCandidatesAsync();
        Task<ResponseDto?> GetCandidateByIdAsync(int id);
        Task<ResponseDto?> CreateCandidateAsync(CandidateProfileDto candidateProfileDto);
        Task<ResponseDto?> UpdateCandidatesAsync(CandidateProfileDto candidateProfileDto);
        Task<ResponseDto?> DeleteCandidatesAsync(int id);
    }
}
