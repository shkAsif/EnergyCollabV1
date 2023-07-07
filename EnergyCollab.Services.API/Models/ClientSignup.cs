using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EnergyCollab.Services.API.Models
{
    public class ClientSignup
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [DisplayName("Name Of Company")]
        public string NameOfCompany { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Required]
        public string Password { get; set; }

        public string? ConfirmPassword { get; set; }
        public string? Plan { get; set; }
        public DateTime CreatedDated { get; set; }
        public bool IsActive { get;}
        public DateTime ModifiedDate { get; set; }



    }
}
