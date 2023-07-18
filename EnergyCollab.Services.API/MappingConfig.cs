using AutoMapper;
using EnergyCollab.API.Dto;
using EnergyCollab.Models;
using EnergyCollab.Services.API.Dto;
using EnergyCollab.Services.API.HelperMethod;
using EnergyCollab.Services.API.Models;
using EnergyCollab.Web.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EnergyCollab.API
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {          

            CreateMap<CandidateProfileDto,CandidateProfile>().ReverseMap();
            
            CreateMap<LoginDto, Login>().ReverseMap();
            CreateMap<ClientSignupDto, ClientSignup>().ReverseMap();


            CreateMap<CountryDto, Country>()
            .ForMember(i => i.CountryCode, opt => opt.MapFrom(i => i.CountryCode))
            .ReverseMap();            

            CreateMap<Vacancy, VacancyDto>()
           .ForMember(i => i.JobTitle, opt => opt.MapFrom(i => i.JobTitle))
           .ForMember(i => i.CompanyName, opt => opt.MapFrom(i => i.organization.Name))
           .ForMember(i => i.Responsibilities, opt => opt.MapFrom(i => i.Responsibilities))
           .ForMember(i => i.Salary, opt => opt.MapFrom(i => i.Salary))
           .ForMember(i => i.Country, opt => opt.MapFrom(i => i.country.Name))
           //.ForMember(i => i.EmpCategory, opt => opt.MapFrom(i => i.EmpCategory))
           .ForMember(x => x.EmpCategory, opt => opt.MapFrom(i => Helper.GetCategoryName((int)i.EmpCategory)))
           .ForMember(i => i.City, opt => opt.MapFrom(i => i.country.City))
           .ForMember(i => i.Education, opt => opt.MapFrom(i => i.Education))
           .ForMember(i => i.CountryCode, opt => opt.MapFrom(i => i.country.CountryCode))
           .ForMember(i => i.Experience, opt => opt.MapFrom(i => i.experience.Range))
           ;

            CreateMap<Organization, OrgSummaryDto>()
             .ForMember(org => org.OrgId, opt => opt.MapFrom(u => u.Id))
             .ForMember(org => org.OrgName, opt => opt.MapFrom(u => u.Name))
             .ForMember(org => org.OrgContactPerson, opt => opt.MapFrom(u => u.OrgDetails.PrimaryContact))
             .ForMember(org => org.OrgEmail, opt => opt.MapFrom(u => u.OrgDetails.Email))
            ;

            CreateMap<OrgDetail,OrgDetailDto>()
                .ForMember(org => org.OrgSummary, opt => opt.MapFrom(u => u.organization))
                .ForMember(org => org.Id, opt => opt.MapFrom(u => u.Id))
                .ReverseMap();

            CreateMap<UserEmail, UserEmailDto>().ReverseMap();

            CreateMap<UserEmailDtov2, UserEmail>().ReverseMap();
            CreateMap<UserGroupDtov2, UserGroup>().ReverseMap();
          

            CreateMap<UserGroupDto, UserGroup>()
                .ForMember(u => u.UserGroupName, opt => opt.MapFrom(u => u.UserGroupName))
                .ForMember(u => u.UserName, opt => opt.MapFrom(u => u.UserName))
                .ForMember(u => u.UserEmails, opt => opt.MapFrom(src => src.UserEmails.Select(email => new UserEmail { Email = email })))
                .ForMember(u => u.CreatedDateTime, opt => opt.MapFrom(u => u.CreatedDateTime))
                .ForMember(u => u.LastUpdatedDateTime, opt => opt.MapFrom(u => u.LastUpdatedDateTime))
                .ReverseMap()
                ;

            CreateMap<SignUpDto, SignUp>()
                .ForMember(u => u.Email, opt => opt.MapFrom(u => u.Email))
                .ForMember(u => u.CandidateProfile, opt => opt.MapFrom(u => u.candidateProfileDto))
                .ReverseMap();

        }
    }
}
