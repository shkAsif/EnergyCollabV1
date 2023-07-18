using EnergyCollab.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
        public string? ConfirmPassword { get; set; }
        public string? CompanyName { get; set; }
        public string? LoginUser { get; set; }

        //One to One Mapping
        public CandidateProfile CandidateProfile { get; set; }


        //Contact Information : 7property
        //Social Links : 3 property
        //Primary Information : 4 property
        //Professional Background and Preferences 9 property
        //Upload CV:
        //Summary:
    }
    public partial class SignUpConfiguration : IEntityTypeConfiguration<SignUp>
    {
        public void Configure(EntityTypeBuilder<SignUp> modelBuilder)
        {
            modelBuilder.HasIndex(e => e.Id);

            //One-To-One Relationship
            modelBuilder.HasOne(u => u.CandidateProfile)
                .WithOne(e => e.SignUp)
                .HasForeignKey<CandidateProfile>(e => e.SignUpId);
        }
    }
}
