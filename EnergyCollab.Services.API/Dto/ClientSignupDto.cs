using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EnergyCollab.Services.API.Dto
{
    public class ClientSignupDto
    {

        [Required]
        public string Email { get; set; }
        [DisplayName("Name Of Company")]
        public string NameOfCompany { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Required]
        public string Password { get; set; }

        public string? ConfirmPassword { get; set; }
    }
}
