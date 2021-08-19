using System.ComponentModel.DataAnnotations;

namespace BCP.ExchangeRate.Domain.Dtos
{
    public class CurrencyForCreation
    {
        [Required]
        [MaxLength(3)]
        public string Code { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
