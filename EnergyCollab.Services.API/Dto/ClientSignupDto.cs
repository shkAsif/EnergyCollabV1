using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EnergyCollab.Services.API.Dto
{
    public class ClientSignupDto
    {
        public string Email { get; set; }
        public string NameOfCompany { get; set; }
        public string Plan { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Password { get; set; }
        public string? ConfirmPassword { get; set; }
        public DateTime CreatedDated { get; set; } = DateTime.Now;
        public bool IsActive { get; } = true;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}
