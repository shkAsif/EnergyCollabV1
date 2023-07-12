﻿using AutoMapper;
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
            CreateMap<CandidateProfileDto, CandidateProfile>();
            CreateMap<CandidateProfile, CandidateProfileDto>();
            CreateMap<SignUpDto, SignUp>().ReverseMap();
            CreateMap<LoginDto, Login>().ReverseMap();
            CreateMap<CountryDto, Country>()
            .ForMember(i => i.CountryCode, opt => opt.MapFrom(i => i.CountryCode))
            .ReverseMap();
            CreateMap<ClientSignup, ClientSignupDto>().ReverseMap();
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
        }
    }
}
