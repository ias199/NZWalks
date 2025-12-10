using AutoMapper;
using NZWalks.API.Models;
using NZWalks.API.Models.DTOs;

namespace NZWalks.API.Mapping
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Region, RegionDto>().ReverseMap();
        }
    }
}
