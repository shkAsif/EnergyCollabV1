using EnergyCollab.Services.API.Models;
using EnergyCollab.Web.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace EnergyCollab.Models;
public partial class CandidateProfile
{
    public int Id { get; set; }
    public Guid? UserAccountId { get; set; }
    public string? CountryCode { get; set; }
    public string? CityName { get; set; }
    public string? AddressOne { get; set; }
    public string? AddressTwo { get; set; }
    public string? PostCode { get; set; }
    public string? PrimaryContactNumber { get; set; }
    public string? SecondaryContactNumber { get; set; }
    public string? CurrentCompanyName { get; set; }
    public string? CurrentJobTitle { get; set; }
    public string? NationalityCodeValue { get; set; }
    public bool? WillingToTravel { get; set; }
    public string? WillingToRelocateCodeValue { get; set; }
    public string? AuthorisedToWorkCodeValues { get; set; }
    public string? IndustryExperienceCodeValue { get; set; }
    public string? EmploymentTypeCodeValues { get; set; }
    public string? EducationCodeValue { get; set; }
    public string? SummaryOfExperienceCategoryCodeValue { get; set; }
    public string? ExperienceDisciplineFirstLevelCodeValue { get; set; }
    public Guid? CvFileId { get; set; }
    public DateTime? LastCvUpdateDateTime { get; set; }
    public string? PersonalWebSiteUrl { get; set; }
    public string? FacebookUrl { get; set; }
    public string? LinkedinUrl { get; set; }
    public bool? IsPublic { get; set; }
    public bool? IsActive { get; set; }
    public string? Summary { get; set; }
    public string? ProjectBeingDownManned { get; set; }
    public string? AmountOfPersonnelAvailable { get; set; }
    public string? DescriptionOfPersonnelAvailable { get; set; }
    public DateTime? AvailableDate { get; set; }
    public string? AdditionalInformation { get; set; }
    public string? CompanyName { get; set; }
    public string? ContactPerson { get; set; }
    public string? Title { get; set; }
    public string? Email { get; set; }
    public string? TelephoneNumber { get; set; }
    public string? Location { get; set; }

    //One to One Mapping
    public int SignUpId { get; set; }   
    public SignUp  SignUp { get; set; }
    //One to One Mapping
    //public int FileDetailId { get; set; }
    //public FileDetail FileDetail { get; set; }
}
public partial class CandidateProfileConfiguration : IEntityTypeConfiguration<CandidateProfile>
{
    public void Configure(EntityTypeBuilder<CandidateProfile> modelBuilder)
    {
        modelBuilder.HasIndex(e => e.Id);        
        
    }
}