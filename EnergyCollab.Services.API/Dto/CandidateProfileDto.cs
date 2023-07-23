using EnergyCollab.Services.API.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EnergyCollab.API.Dto
{
    public class CandidateProfileDto
    {
        //public int Id { get; set; }
        public Guid? UserAccountId { get; set; } = Guid.NewGuid();
        public string? CountryCode { get; set; } = string.Empty;
        public string? CityName { get; set; } = string.Empty;
        public string? AddressOne { get; set; } = string.Empty;
        public string? AddressTwo { get; set; } = string.Empty;
        public string? PostCode { get; set; } = string.Empty;
        public string? PrimaryContactNumber { get; set; } = string.Empty;
        public string? SecondaryContactNumber { get; set; } = string.Empty;
        public string? CurrentCompanyName { get; set; } = string.Empty;
        public string? CurrentJobTitle { get; set; } = string.Empty;
        public string? NationalityCodeValue { get; set; } = string.Empty;
        public bool? WillingToTravel { get; set; }
        public string? WillingToRelocateCodeValue { get; set; } = string.Empty;
        public string? AuthorisedToWorkCodeValues { get; set; } = string.Empty;
        public string? IndustryExperienceCodeValue { get; set; } = string.Empty;
        public string? EmploymentTypeCodeValues { get; set; } = string.Empty;
        public string? EducationCodeValue { get; set; } = string.Empty;
        public string? SummaryOfExperienceCategoryCodeValue { get; set; }
        public string? ExperienceDisciplineFirstLevelCodeValue { get; set; } = string.Empty;
        public Guid? CvFileId { get; set; } = Guid.NewGuid();
        public DateTime? LastCvUpdateDateTime { get; set; } = DateTime.Now;
        public string? PersonalWebSiteUrl { get; set; } = string.Empty;
        public string? FacebookUrl { get; set; } = string.Empty;
        public string? LinkedinUrl { get; set; } = string.Empty;
        public bool? IsPublic { get; set; }
        public bool? IsActive { get; set; }
        public string? Summary { get; set; } = string.Empty;
        public string? ProjectBeingDownManned { get; set; } = string.Empty;
        public string? AmountOfPersonnelAvailable { get; set; } = string.Empty;
        public string? DescriptionOfPersonnelAvailable { get; set; } = string.Empty;
        public DateTime? AvailableDate { get; set; } = DateTime.Now;
        public string? AdditionalInformation { get; set; } = string.Empty;
        public string? CompanyName { get; set; } = string.Empty;
        public string? ContactPerson { get; set; } = string.Empty;
        public string? Title { get; set; } = string.Empty;
        public string? Email { get; set; } = string.Empty;
        public string? TelephoneNumber { get; set; } = string.Empty;
        public string? Location { get; set; } = string.Empty;       
    }
}
