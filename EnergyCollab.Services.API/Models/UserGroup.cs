using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EnergyCollab.Services.API.Models
{
    public class UserGroup
    {
        public int Id { get; set; }
        public string UserGroupName { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public ICollection<UserEmail> UserEmails { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
        public DateTime LastUpdatedDateTime { get; set; } = DateTime.Now;


    }
    public partial class UserGroupConfiguration : IEntityTypeConfiguration<UserGroup>
    {
        public void Configure(EntityTypeBuilder<UserGroup> modelBuilder)
        {
            modelBuilder.HasIndex(e => e.Id);

            //One-To-Many, UserGroup can have multiple Ids
            modelBuilder.HasMany(u => u.UserEmails)
                        .WithOne(u => u.userGroup)
                        .HasForeignKey(p => p.UserGroupId);
        }
    }


    public class UserEmail
    {
        public int Id { get; set; }
        public string Email { get; set; }

        public int UserGroupId { get; set; }
        public UserGroup userGroup { get; set; }
    }
    public partial class UserEmailConfiguration : IEntityTypeConfiguration<UserEmail>
    {
        public void Configure(EntityTypeBuilder<UserEmail> modelBuilder)
        {
            modelBuilder.HasIndex(e => e.Id);
           
        }
    }

}
