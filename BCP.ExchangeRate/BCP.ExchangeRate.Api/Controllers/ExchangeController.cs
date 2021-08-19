using BCP.ExchangeRate.BusinessLogic.Contracts;
using BCP.ExchangeRate.Domain.Dtos;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BCP.ExchangeRate.Api.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ExchangeController : ControllerBase
    {
        private readonly IExchangeBL _exchangeBL;
        public ExchangeController(IExchangeBL exchangeBL)
        {
            _exchangeBL = exchangeBL ?? throw new ArgumentNullException(nameof(exchangeBL));
        }

        [HttpPost]
        public async Task<IActionResult> CreateRate([FromBody] ExchangeForProcessingDto exchangeForProcessingDto)
        {

            if (exchangeForProcessingDto == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return new UnprocessableEntityObjectResult(ModelState);
            }

            var value = await _exchangeBL.CalculateExchange(exchangeForProcessingDto);

            return Ok(value);
        }
    }
}
