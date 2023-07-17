using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using EnergyCollab.Web.Models;

namespace EnergyCollab.Services.API.Models
{
    public class Login
    {
        public int? Id { get; set; }
        [Required]
        [EmailAddress]
        public string EmailId { get; set; }
        [Required]
        [PasswordPropertyText]
        public string Password { get; set; }
    }
}
