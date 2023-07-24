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
        public FileDetail FileDetail { get; set; }

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

            //One-To-One FileDetail
            modelBuilder.HasOne(u => u.FileDetail)
                .WithOne(e => e.SignUp)
                .HasForeignKey<FileDetail>(e => e.SignUpId);

        }
    }
}
