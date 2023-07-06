using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EnergyCollab.Web.Models
{
    public class ClientSignUpDto
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
