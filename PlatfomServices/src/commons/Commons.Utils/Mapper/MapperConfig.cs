using AutoMapper;
using Domain.Model.Models;
using EntryPoint.Web.Dtos;

namespace Commons.Utils.Mapper
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Platform, CreatePlatformDto>().ReverseMap();
        }
    }
}