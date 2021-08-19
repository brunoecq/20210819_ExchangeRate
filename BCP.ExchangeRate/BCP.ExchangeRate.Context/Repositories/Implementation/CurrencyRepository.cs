using BCP.ExchangeRate.Domain.Models;
using BCP.ExchangeRate.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BCP.ExchangeRate.Persistence.Repositories
{
    public class CurrencyRepository : ICurrencyRepository, IDisposable
    {
        private ERContext _context;

        public CurrencyRepository(ERContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _context.Database.EnsureCreated();
        }

        public async Task<Currency> GetCurrencyAsync(Guid currencyId)
        {
            return await _context.Currencies.FirstOrDefaultAsync(m => m.Id == currencyId);
        }

        public async Task<Currency> GetCurrencyByCodeAsync(string code)
        {
            return await _context.Currencies.Include(m=>m.Rate).FirstOrDefaultAsync(m => m.Code == code);
        }

        public async Task<IEnumerable<Currency>> GetCurrenciesAsync()
        {
            return await _context.Currencies.ToListAsync();
        }

        public void UpdateCurrency(Currency currencyToUpdate)
        {

        }

        public void AddCurrency(Currency currencyToAdd)
        {
            if (currencyToAdd == null)
            {
                throw new ArgumentNullException(nameof(currencyToAdd));
            }

            _context.Add(currencyToAdd);
        }

        public void DeleteCurrency(Currency currencyToDelete)
        {
            if (currencyToDelete == null)
            {
                throw new ArgumentNullException(nameof(currencyToDelete));
            }

            _context.Remove(currencyToDelete);
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
