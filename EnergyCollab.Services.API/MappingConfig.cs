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
        //public static MapperConfiguration RegisterMaps()
        //{
        //    var mappingConfig = new MapperConfiguration(config =>
        //    {
        //        config.CreateMap<CandidateProfileDto, CandidateProfile>();
        //        config.CreateMap<CandidateProfile, CandidateProfileDto>();

        //        config.CreateMap<SignUpDto, SignUp>().ReverseMap();
        //        config.CreateMap<LoginDto, Login>().ReverseMap();
        //        config.CreateMap<CountryDto, Country>().ReverseMap();
        //        config.CreateMap<ClientSignupDto, ClientSignup>().ReverseMap();





        //    });
        //    return mappingConfig;
        //}
        public MappingConfig()
        {
            CreateMap<CandidateProfileDto, CandidateProfile>();
            CreateMap<CandidateProfile, CandidateProfileDto>();

            CreateMap<SignUpDto, SignUp>().ReverseMap();
            CreateMap<LoginDto, Login>().ReverseMap();
            CreateMap<CountryDto, Country>().ReverseMap();
            CreateMap<ClientSignupDto, ClientSignup>().ReverseMap();

            CreateMap<Vacancy, VacancyDto>()
           .ForMember(i => i.JobTitle, opt => opt.MapFrom(i => i.JobTitle))
           .ForMember(i => i.CompanyName, opt => opt.MapFrom(i => i.organization.Name))
           .ForMember(i => i.Responsibilities, opt => opt.MapFrom(i => i.Responsibilities))
           .ForMember(i => i.Salary, opt => opt.MapFrom(i => i.Salary))
           .ForMember(i => i.Country, opt => opt.MapFrom(i => i.country.Name))
           //.ForMember(i => i.EmpCategory, opt => opt.MapFrom(i => i.EmpCategory))
           .ForMember(x => x.EmpCategory, opt => opt.MapFrom(i => Helper.GetCategoryName((int)i.EmpCategory)))
           .ForMember(i => i.City, opt => opt.MapFrom(i => i.country.City))
           .ForMember(i => i.Education, opt => opt.MapFrom(i => i.Education));

        }
    }
}
