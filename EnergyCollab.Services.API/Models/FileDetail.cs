using EnergyCollab.Models;
using EnergyCollab.Services.API.HelperMethod;
using EnergyCollab.Web.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static EnergyCollab.Services.API.HelperMethod.Helper;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;

namespace EnergyCollab.Web.Models
{

    public class FileDetail
    {
        public int Id { get; set; }
        public string? FileName { get; set; }
        //[NotMapped]
        public byte[]? FileData { get; set; }
        public FileType? FileType { get; set; }

        //One to One Mapping
        //public CandidateProfile CandidateProfile { get; set; }

        //One to One Mapping
        public int SignUpId { get; set; }
        public SignUp SignUp { get; set; }

    }
    public partial class FileDetailConfiguration : IEntityTypeConfiguration<FileDetail>
    {
        public void Configure(EntityTypeBuilder<FileDetail> modelBuilder)
        {
            modelBuilder.HasIndex(e => e.Id);

            //One - To - One Relationship
            //modelBuilder.HasOne(u => u.CandidateProfile)
            //    .WithOne(e => e.FileDetail)
            //    .HasForeignKey<CandidateProfile>(e => e.FileDetailId);

            // modelBuilder.Property(x => x.FileData)
            //.HasConversion(new ValueConverter<byte[],BinaryData>(
            //    v => JsonConvert.SerializeObject(v), // Convert to string for persistence
            //    v => JsonConvert.DeserializeObject<BinaryData>(v))); // Convert to List<String> for use

        }
    }
}
