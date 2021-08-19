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
    public class RateBL : IRateBL
    {
        private readonly IRateRepository _RateRepository;
        private readonly IMapper _mapper;
        public RateBL(IRateRepository RateRepository, IMapper mapper)
        {
            _RateRepository = RateRepository ?? throw new ArgumentNullException(nameof(RateRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<IEnumerable<RateDto>> GetRates()
        {
            var RateEntities = await _RateRepository.GetRatesAsync();
            return _mapper.Map<IEnumerable<RateDto>>(RateEntities);
        }

        public async Task<RateDto> GetRate(Guid RateId)
        {
            var RateEntity = await _RateRepository.GetRateAsync(RateId);
            if (RateEntity == null)
            {
                return null;
            }

            return _mapper.Map<RateDto>(RateEntity);
        }

        public async Task<RateDto> CreateRate(RateForCreation RateForCreation)
        {
            if (RateForCreation == null) return null;

            var RateEntity = _mapper.Map<Rate>(RateForCreation);
            _RateRepository.AddRate(RateEntity);

            await _RateRepository.SaveChangesAsync();

            await _RateRepository.GetRateAsync(RateEntity.Id);

            return _mapper.Map<RateDto>(RateEntity);
        }

        public async Task<RateDto> UpdateRate(Guid RateId, RateForUpdate RateForUpdate)
        {

            if (RateForUpdate == null) return null;

            var RateEntity = await _RateRepository.GetRateAsync(RateId);

            if (RateEntity == null) return null;

            _mapper.Map(RateForUpdate, RateEntity);

            _RateRepository.UpdateRate(RateEntity);

            await _RateRepository.SaveChangesAsync();

            await _RateRepository.GetRateAsync(RateEntity.Id);

            return _mapper.Map<RateDto>(RateEntity);
        }

        public async Task DeleteRate(Guid RateId)
        {
            var RateEntity = await _RateRepository.GetRateAsync(RateId);
            if (RateEntity == null) return;

            _RateRepository.DeleteRate(RateEntity);
            await _RateRepository.SaveChangesAsync();
        }
    }
}
