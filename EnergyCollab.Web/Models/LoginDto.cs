using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace EnergyCollab.Web.Models
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
