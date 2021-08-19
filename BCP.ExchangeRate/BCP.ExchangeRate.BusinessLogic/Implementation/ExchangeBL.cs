using AutoMapper;
using BCP.ExchangeRate.BusinessLogic.Contracts;
using BCP.ExchangeRate.Domain.Dtos;
using BCP.ExchangeRate.Persistence.Repositories;
using System;
using System.Threading.Tasks;

namespace BCP.ExchangeRate.BusinessLogic.Implementation
{
    public class ExchangeBL : IExchangeBL
    {
        private readonly ICurrencyRepository _currencyRepository;
        public ExchangeBL(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository ?? throw new ArgumentNullException(nameof(currencyRepository));
        }

        public async Task<ExchangeForResponseDto> CalculateExchange(ExchangeForProcessingDto exchangeForProcessingDto)
        {
            var source = await _currencyRepository.GetCurrencyByCodeAsync(exchangeForProcessingDto.SourceCurrency);
            
            var destination = await _currencyRepository.GetCurrencyByCodeAsync(exchangeForProcessingDto.DestinationCurrency);
            
            if (source == null || destination == null) return null;

            var exchangeRate = source.Rate.AverageRate / destination.Rate.AverageRate;

            return new ExchangeForResponseDto() { 
                Amount = exchangeForProcessingDto.Amount,
                AmountExchanged = exchangeForProcessingDto.Amount * exchangeRate,
                DestinationCurrency = exchangeForProcessingDto.DestinationCurrency,
                SourceCurrency = exchangeForProcessingDto.SourceCurrency,
                Rate = exchangeRate
            };
        }

        
    }
}
