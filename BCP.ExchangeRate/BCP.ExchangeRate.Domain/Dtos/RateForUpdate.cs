using System;

namespace BCP.ExchangeRate.Domain.Dtos
{
    public class RateForUpdate
    {
        public double AverageRate { get; set; }

        public DateTimeOffset Date { get; set; }
        public DateTimeOffset EndOfDay { get; set; }

        public Guid CurrencyId { get; set; }
    }
}
