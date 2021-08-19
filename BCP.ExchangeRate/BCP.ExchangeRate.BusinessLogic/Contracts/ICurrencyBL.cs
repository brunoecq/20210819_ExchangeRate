using BCP.ExchangeRate.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BCP.ExchangeRate.BusinessLogic.Contracts
{
    public interface ICurrencyBL
    {
        Task<IEnumerable<CurrencyDto>> GetCurrencies();
        Task<CurrencyDto> GetCurrency(Guid currencyId);
        Task<CurrencyDto> CreateCurrency(CurrencyForCreation currencyForCreation);
        Task<CurrencyDto> UpdateCurrency(Guid currencyId, CurrencyForUpdate currencyForUpdate);
        Task DeleteCurrency(Guid currencyId);
    }
}
