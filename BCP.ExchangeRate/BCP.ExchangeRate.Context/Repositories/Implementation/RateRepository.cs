using BCP.ExchangeRate.Domain.Models;
using BCP.ExchangeRate.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BCP.ExchangeRate.Persistence.Repositories
{
    public class RateRepository : IRateRepository, IDisposable
    {
        private ERContext _context;

        public RateRepository(ERContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _context.Database.EnsureCreated();
        }

        public async Task<Rate> GetRateAsync(Guid rateId)
        {
            return await _context.Rates.Include(m => m.Currency).FirstOrDefaultAsync(m => m.Id == rateId);
        }

        public async Task<IEnumerable<Rate>> GetRatesAsync()
        {
            return await _context.Rates.Include(m => m.Currency).ToListAsync();
        }

        public void UpdateRate(Rate rateToUpdate)
        {
        }

        public void AddRate(Rate rateToAdd)
        {
            if (rateToAdd == null)
            {
                throw new ArgumentNullException(nameof(rateToAdd));
            }

            _context.Add(rateToAdd);
        }

        public void DeleteRate(Rate rateToDelete)
        {
            if (rateToDelete == null)
            {
                throw new ArgumentNullException(nameof(rateToDelete));
            }

            _context.Remove(rateToDelete);
        }

        public async Task<bool> SaveChangesAsync()
        {
            // return true if 1 or more entities were changed
            return (await _context.SaveChangesAsync() > 0);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }
    }
}
