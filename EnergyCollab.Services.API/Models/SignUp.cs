using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EnergyCollab.Web.Models
{
    public class SignUp
    {
        
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }
    }
}
