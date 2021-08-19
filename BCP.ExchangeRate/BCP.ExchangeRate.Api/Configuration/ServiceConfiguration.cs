using BCP.ExchangeRate.BusinessLogic.Contracts;
using BCP.ExchangeRate.BusinessLogic.Implementation;
using BCP.ExchangeRate.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BCP.ExchangeRate.Api.Configuration
{
    public static class ServiceConfiguration
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddTransient<ICurrencyRepository, CurrencyRepository>();
            services.AddTransient<IRateRepository, RateRepository>();
            services.AddTransient<ICurrencyBL, CurrencyBL>();
            services.AddTransient<IRateBL, RateBL>();
            services.AddTransient<IExchangeBL, ExchangeBL>();
        }
    }
}
