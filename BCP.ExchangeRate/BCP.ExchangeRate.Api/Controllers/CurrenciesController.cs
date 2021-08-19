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
    public class CurrenciesController : ControllerBase
    {
        private readonly ICurrencyBL _currencyBL;
        public CurrenciesController(ICurrencyBL currencyBL)
        {
            _currencyBL = currencyBL ?? throw new ArgumentNullException(nameof(currencyBL));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurrencyDto>>> GetCurrencies()
        {
            var list = await _currencyBL.GetCurrencies();
            return Ok(list);
        }


        [HttpGet("{currencyId}", Name = "GetCurrency")]
        public async Task<ActionResult<CurrencyDto>> GetCurrency(Guid currencyId)
        {
            var o = await _currencyBL.GetCurrency(currencyId);

            if (o == null)
            {
                return NotFound();
            }

            return Ok(o);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCurrency([FromBody] CurrencyForCreation currencyForCreation)
        {

            if (currencyForCreation == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return new UnprocessableEntityObjectResult(ModelState);
            }

            var currency = await _currencyBL.CreateCurrency(currencyForCreation);

            return CreatedAtRoute("GetCurrency", new { currencyId = currency.Id }, currency);
        }

        [HttpPut("{currencyId}")]
        public async Task<IActionResult> UpdateCurrency(Guid currencyId,
            [FromBody] CurrencyForUpdate currencyForUpdate)
        {
            if (currencyForUpdate == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return new UnprocessableEntityObjectResult(ModelState);
            }

            var o = await _currencyBL.UpdateCurrency(currencyId, currencyForUpdate);
            if (o == null)
            {
                return NotFound();
            }

            return Ok(o);
        }

        [HttpDelete("{currencyId}")]
        public async Task<IActionResult> DeleteCurrency(Guid currencyId)
        {
            await _currencyBL.DeleteCurrency(currencyId);

            return NoContent();
        }
    }
}
