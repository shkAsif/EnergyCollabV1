using EnergyCollab.API.Dto;
using EnergyCollab.Models;

namespace EnergyCollab.Services.API.Dto
{
    public class SignUpDto
    {
        //public int Id { get; set; }    
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }

        public CandidateProfileDto candidateProfileDto { get; set; } = new();
        public FileDetailDto fileDetailDto { get; set; } = new();
        
        
       
    }
}
