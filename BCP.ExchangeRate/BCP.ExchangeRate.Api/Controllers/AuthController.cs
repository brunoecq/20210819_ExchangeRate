using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BCP.ExchangeRate.Api.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class AuthController : Controller
    {
        private readonly IConfiguration _configuration;
        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Login()
        {

            var user = new
            {
                Name = "Bruno",
                Email = "bruno.ecq@gmail.com",
                UserId = "a79b2e64-axce-4f3a-8cf6-a68ba400db12"
            };


            var secretKey = _configuration.GetValue<string>("SecretKey");
            var key = Encoding.ASCII.GetBytes(secretKey);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserId),
                new Claim(ClaimTypes.Email, user.Email)
            };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var createdToken = tokenHandler.CreateToken(tokenDescriptor);

            return Ok(tokenHandler.WriteToken(createdToken));
        }
    }
}
