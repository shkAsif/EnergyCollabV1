using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCollab.Services.API.Models
{
    public class OrgDetail
    {
        public int Id { get; set; }

        //Foregin Key
        public Organization organization { get; set; }
        public int? organizationId { get; set; }


        // Company Profile Tab
        public string PrimaryContact { get; set; }
        public string Email { get; set; }
        public string Package { get; set; } // Gold , Platinum , Silver
        public int AdministratorCount { get; set; }
        public int ExecutiveCount { get; set; }
        public int AnnuallyJobPostCount { get; set; }
        public string TimeZone { get; set; }
        public string Logo { get; set; }
        public string Url { get; set; }
        public string FacebookURL { get; set; }
        public string AddressOne { get; set; }
        public string AddressTwo { get; set; }
        public string PostCode { get; set; }
        public string PrimayContactNumber { get; set; }
        public string SecondaryContactNumber { get; set; }
        public bool ActivationStatus { get; set; }

        //Invitation Tab 
        public string InviteLink { get; set; }

        //Users Tab
        string PendingUser { get; set; }
        public string Approve { get; set; }

        //Community Network Tab
        public string Region { get; set; }
        public string ExpertiseIndustry { get; set; }
        public string Position { get; set; }
        public string CommPostCode { get; set; }
        public string Description { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string CommDescription { get; set; }

    }
    public partial class OrgDetailConfiguration : IEntityTypeConfiguration<OrgDetail>
    {
        public void Configure(EntityTypeBuilder<OrgDetail> modelBuilder)
        {
            modelBuilder.HasIndex(e => e.Id);

            // One-To-One
            modelBuilder.HasOne(e => e.organization)
                        .WithOne(e => e.OrgDetails)
                        .HasForeignKey<OrgDetail>(e => e.organizationId)
                        .IsRequired();

        }
    }
}

