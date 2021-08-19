using System;

namespace BCP.ExchangeRate.Domain.Dtos
{
    public class ExchangeForResponseDto
    {
        public decimal Amount { get; set; }
        public decimal AmountExchanged { get; set; }
        public decimal Rate { get; set; }
        public string SourceCurrency { get; set; }
        public string DestinationCurrency { get; set; }
    }
}
