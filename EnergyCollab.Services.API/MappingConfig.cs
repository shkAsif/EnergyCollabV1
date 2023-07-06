using AutoMapper;
using EnergyCollab.API.Dto;
using EnergyCollab.Models;
using EnergyCollab.Services.API.Dto;
using EnergyCollab.Services.API.Migrations;
using EnergyCollab.Services.API.Models;
using EnergyCollab.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCollab.API
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CandidateProfileDto, CandidateProfile>();
                config.CreateMap<CandidateProfile, CandidateProfileDto>();

                config.CreateMap<SignUpDto, SignUp>().ReverseMap();
                config.CreateMap<LoginDto, Login>().ReverseMap();



            });
            return mappingConfig;
        }
    }
}
