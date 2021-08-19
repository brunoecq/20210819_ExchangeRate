using AutoMapper;
using BCP.ExchangeRate.BusinessLogic.Contracts;
using BCP.ExchangeRate.Domain.Dtos;
using BCP.ExchangeRate.Domain.Models;
using BCP.ExchangeRate.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BCP.ExchangeRate.BusinessLogic.Implementation
{
    public class CurrencyBL : ICurrencyBL
    {
        private readonly ICurrencyRepository _currencyRepository;
        private readonly IMapper _mapper;
        public CurrencyBL(ICurrencyRepository currencyRepository, IMapper mapper)
        {
            _currencyRepository = currencyRepository ?? throw new ArgumentNullException(nameof(currencyRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<IEnumerable<CurrencyDto>> GetCurrencies()
        {
            var currencyEntities = await _currencyRepository.GetCurrenciesAsync();
            return _mapper.Map<IEnumerable<CurrencyDto>>(currencyEntities);
        }

        public async Task<CurrencyDto> GetCurrency(Guid currencyId)
        {
            var currencyEntity = await _currencyRepository.GetCurrencyAsync(currencyId);
            if (currencyEntity == null)
            {
                return null;
            }

            return _mapper.Map<CurrencyDto>(currencyEntity);
        }

        public async Task<CurrencyDto> CreateCurrency(CurrencyForCreation currencyForCreation)
        {
            if (currencyForCreation == null) return null;

            var currencyEntity = _mapper.Map<Currency>(currencyForCreation);
            _currencyRepository.AddCurrency(currencyEntity);

            await _currencyRepository.SaveChangesAsync();

            await _currencyRepository.GetCurrencyAsync(currencyEntity.Id);

            return _mapper.Map<CurrencyDto>(currencyEntity);
        }

        public async Task<CurrencyDto> UpdateCurrency(Guid currencyId, CurrencyForUpdate currencyForUpdate)
        {

            if (currencyForUpdate == null) return null;

            var currencyEntity = await _currencyRepository.GetCurrencyAsync(currencyId);

            if (currencyEntity == null) return null;

            _mapper.Map(currencyForUpdate, currencyEntity);

            _currencyRepository.UpdateCurrency(currencyEntity);

            await _currencyRepository.SaveChangesAsync();

            await _currencyRepository.GetCurrencyAsync(currencyEntity.Id);

            return _mapper.Map<CurrencyDto>(currencyEntity);
        }

        public async Task DeleteCurrency(Guid currencyId)
        {
            var currencyEntity = await _currencyRepository.GetCurrencyAsync(currencyId);
            if (currencyEntity == null) return;

            _currencyRepository.DeleteCurrency(currencyEntity);
            await _currencyRepository.SaveChangesAsync();
        }
    }
}
