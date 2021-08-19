using System;
using System.ComponentModel.DataAnnotations;

namespace BCP.ExchangeRate.Domain.Dtos
{
    public class ExchangeForProcessingDto
    {
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public string SourceCurrency { get; set; }
        [Required]
        public string DestinationCurrency { get; set; }
        public int IsPreferencial { get; set; }
        public decimal RateDiscount { get; set; }
    }
}
