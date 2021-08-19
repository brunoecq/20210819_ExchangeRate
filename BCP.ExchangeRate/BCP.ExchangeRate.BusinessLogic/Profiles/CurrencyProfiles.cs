using AutoMapper;
using BCP.ExchangeRate.Domain.Dtos;
using BCP.ExchangeRate.Domain.Models;

namespace BCP.ExchangeRate.BusinessLogic.Profiles
{
    public class CurrencyProfiles : Profile
    {
        public CurrencyProfiles()
        {
            CreateMap<Currency, CurrencyDto>();

            CreateMap<CurrencyForCreation, Currency>();

            CreateMap<CurrencyForUpdate, Currency>().ReverseMap();
        }
    }
}
