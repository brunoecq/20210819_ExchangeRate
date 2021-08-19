using System;

namespace BCP.ExchangeRate.Domain.Dtos
{
    public class RateForCreation
    {
        public double AverageRate { get; set; }

        public DateTime Date { get; set; }
        public DateTime EndOfDay { get; set; }

        public Guid CurrencyId { get; set; }
    }
}
