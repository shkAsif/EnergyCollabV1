using System.ComponentModel.DataAnnotations;
namespace EnergyCollab.Web.Models
{
    public class SignUpDto
    {
        [Required]
        public string Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Required]
        public string Password { get; set; }
        public string? ConfirmPassword { get; set; }
    }
}
