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
    public class RatesController : ControllerBase
    {
        private readonly IRateBL _rateBL;
        public RatesController(IRateBL rateBL)
        {
            _rateBL = rateBL ?? throw new ArgumentNullException(nameof(rateBL));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RateDto>>> GetRates()
        {
            var list = await _rateBL.GetRates();
            return Ok(list);
        }


        [HttpGet("{RateId}", Name = "GetRate")]
        public async Task<ActionResult<RateDto>> GetRate(Guid rateId)
        {
            var o = await _rateBL.GetRate(rateId);

            if (o == null)
            {
                return NotFound();
            }

            return Ok(o);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRate([FromBody] RateForCreation rateForCreation)
        {

            if (rateForCreation == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return new UnprocessableEntityObjectResult(ModelState);
            }

            var Rate = await _rateBL.CreateRate(rateForCreation);

            return CreatedAtRoute("GetRate", new { RateId = Rate.Id }, Rate);
        }

        [HttpPut("{RateId}")]
        public async Task<IActionResult> UpdateRate(Guid rateId,
            [FromBody] RateForUpdate RateForUpdate)
        {
            if (RateForUpdate == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return new UnprocessableEntityObjectResult(ModelState);
            }

            var o = await _rateBL.UpdateRate(rateId, RateForUpdate);
            if (o == null)
            {
                return NotFound();
            }

            return Ok(o);
        }

        [HttpDelete("{RateId}")]
        public async Task<IActionResult> DeleteRate(Guid rateId)
        {
            await _rateBL.DeleteRate(rateId);

            return NoContent();
        }
    }
}
