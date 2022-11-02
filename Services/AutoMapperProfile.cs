using AutoMapper;
using DAL.Domain;
using Services.AgencyService;
using Services.LocalityService;

namespace Services
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Agency, AgencyDto>()
                .ForMember(a => a.State, opt => opt.MapFrom(src => src.Locality.State));

            CreateMap<Locality, LocalityDto>().ReverseMap();

            CreateMap<ParseAgencyDto, Agency>();
        }
    }
}
