using BCP.ExchangeRate.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BCP.ExchangeRate.Persistence.Repositories
{
    public interface ICurrencyRepository
    {
        Task<Currency> GetCurrencyAsync(Guid currencyId);

        Task<Currency> GetCurrencyByCodeAsync(string code);

        Task<IEnumerable<Currency>> GetCurrenciesAsync();

        void UpdateCurrency(Currency currencyToUpdate);

        void AddCurrency(Currency currencyToAdd);

        void DeleteCurrency(Currency currencyToDelete);

        Task<bool> SaveChangesAsync();

        void Dispose();

    }
}
