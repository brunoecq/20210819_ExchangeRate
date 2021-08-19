using BCP.ExchangeRate.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BCP.ExchangeRate.BusinessLogic.Contracts
{
    public interface IRateBL
    {
        Task<IEnumerable<RateDto>> GetRates();
        Task<RateDto> GetRate(Guid RateId);
        Task<RateDto> CreateRate(RateForCreation RateForCreation);
        Task<RateDto> UpdateRate(Guid RateId, RateForUpdate RateForUpdate);
        Task DeleteRate(Guid RateId);
    }
}
