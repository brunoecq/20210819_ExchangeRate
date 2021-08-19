using BCP.ExchangeRate.Domain.Models.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace BCP.ExchangeRate.Domain.Models
{
    public class Rate : Audit
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(200)]
        public decimal AverageRate { get; set; }

        [Required]
        public DateTimeOffset Date { get; set; }
        [Required]
        public DateTimeOffset EndOfDay { get; set; }

        [Required]
        public Guid CurrencyId { get; set; }
        public Currency Currency { get; set; }
    }
}
