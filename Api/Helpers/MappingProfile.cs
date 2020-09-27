using Api.DTOs;
using Api.Entities;
using AutoMapper;

namespace Api.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Part, PartDTO>()
                .ForMember(d => d.PartType, o => o.MapFrom(s => s.PartType.Name));
        }
    }
}