using BCP.ExchangeRate.Domain.Models.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace BCP.ExchangeRate.Domain.Models
{
    public class Currency : Audit
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(3)]
        public string Code { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        public Rate Rate { get; set; }
    }
}
