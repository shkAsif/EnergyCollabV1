using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace EnergyCollab.Services.API.Dto
{
    public class LoginDto
    {
        
        
        [Required]
        [EmailAddress]
        public string EmailId { get; set; }
        [Required]
        [PasswordPropertyText]
        public string Password { get; set; }
    }
}
