namespace EnergyCollab.Web.Models
{
    public class JobSeekerLoginModel
    {
        public int JobSeekerLoginModelId { get; set; }
        public required string Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public required string Password { get; set; }
        public required string ConfirmPassword { get; set; }
    }
}
