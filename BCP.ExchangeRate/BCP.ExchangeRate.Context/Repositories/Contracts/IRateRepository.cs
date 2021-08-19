using BCP.ExchangeRate.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BCP.ExchangeRate.Persistence.Repositories
{
    public interface IRateRepository
    {
        Task<Rate> GetRateAsync(Guid RateId);

        Task<IEnumerable<Rate>> GetRatesAsync();

        void UpdateRate(Rate RateToUpdate);

        void AddRate(Rate RateToAdd);

        void DeleteRate(Rate RateToDelete);

        Task<bool> SaveChangesAsync();

        void Dispose();
    }
}
