using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace EnergyCollab.Web.Models
{
    public class SignUpDto
    {
        [Required]
        public string Email { get; set; }
        [DisplayName("First Name")]
        public string? FirstName { get; set; }
        [DisplayName("Last Name")]
        public string? LastName { get; set; }
        [Required]
        public string Password { get; set; }
        [DisplayName("Confirm Password")]
        public string? ConfirmPassword { get; set; }
    }
}
