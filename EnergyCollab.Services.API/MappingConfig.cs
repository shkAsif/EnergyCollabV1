using AutoMapper;
using EnergyCollab.API.Dto;
using EnergyCollab.Models;
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
            });
            return mappingConfig;
        }
    }
}
