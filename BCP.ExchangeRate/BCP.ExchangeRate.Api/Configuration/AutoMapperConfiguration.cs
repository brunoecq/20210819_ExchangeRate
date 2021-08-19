using BCP.ExchangeRate.BusinessLogic.Profiles;
using Microsoft.Extensions.DependencyInjection;

namespace BCP.ExchangeRate.Api.Configuration
{
    public static class AutoMapperConfiguration
    {
        public static void ConfigureAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CurrencyProfiles).Assembly);
            services.AddAutoMapper(typeof(RateProfiles).Assembly);
        }
    }
}
