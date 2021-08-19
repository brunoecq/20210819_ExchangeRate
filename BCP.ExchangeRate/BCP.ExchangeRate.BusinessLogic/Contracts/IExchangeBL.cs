using BCP.ExchangeRate.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BCP.ExchangeRate.BusinessLogic.Contracts
{
    public interface IExchangeBL
    {
        Task<ExchangeForResponseDto> CalculateExchange(ExchangeForProcessingDto exchangeForProcessingDto);
    }
}
