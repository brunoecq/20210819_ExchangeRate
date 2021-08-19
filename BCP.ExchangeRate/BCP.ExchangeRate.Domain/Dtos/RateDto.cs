using System;

namespace BCP.ExchangeRate.Domain.Dtos
{
    public class RateDto
    {
        public Guid Id { get; set; }

        public double AverageRate { get; set; }

        public string Date { get; set; }
        public string EndOfDay { get; set; }

        public Guid CurrencyId { get; set; }
        public CurrencyDto Currency { get; set; }
    }
}
