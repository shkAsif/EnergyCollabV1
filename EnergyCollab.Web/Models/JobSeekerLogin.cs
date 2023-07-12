using System.ComponentModel;

namespace EnergyCollab.Web.Models
{
    public class JobSeekerLogin
    {
        public int Id { get; set; }
        public required string Email { get; set; }
        [DisplayName(" First Name")]
        public string? FirstName { get; set; }
        [DisplayName(" Last Name")]
        public string? LastName { get; set; }
        public required string Password { get; set; }
        [DisplayName("Confirm Password")]
        public required string ConfirmPassword { get; set; }
    }
}
