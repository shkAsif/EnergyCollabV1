using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace EnergyCollab.Web.Models
{
    public class ClientSignUpDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [DisplayName("Company Name")]
        public string NameOfCompany { get; set; }
        public string Plan { get; set; }
        [DisplayName("First Name")]
        public string? FirstName { get; set; }
        [DisplayName("Last Name")]
        public string? LastName { get; set; }
        [Required]
        [PasswordPropertyText]  
        public string Password { get; set; }
        [DisplayName("Confirm Password")]
        public string? ConfirmPassword { get; set; }
        public DateTime CreatedDated { get; set; } = DateTime.Now;
        public bool IsActive { get; } = true;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}
