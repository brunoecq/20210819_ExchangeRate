using AutoMapper;
using BCP.ExchangeRate.Domain.Dtos;
using BCP.ExchangeRate.Domain.Models;

namespace BCP.ExchangeRate.BusinessLogic.Profiles
{
    public class RateProfiles : Profile
    {
        public RateProfiles()
        {
            CreateMap<Rate, RateDto>();

            CreateMap<RateForCreation, Rate>();

            CreateMap<RateForUpdate, Rate>().ReverseMap();
        }
    }
}
