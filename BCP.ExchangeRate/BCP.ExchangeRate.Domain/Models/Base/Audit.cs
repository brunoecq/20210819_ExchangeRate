using System;

namespace BCP.ExchangeRate.Domain.Models.Base
{
    public abstract class Audit
    {
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatdeAt { get; set; }
    }
}
