using BCP.ExchangeRate.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BCP.ExchangeRate.Api.Configuration
{
    public static class DatabaseConfiguration
    {
        public static void AddDbContext(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ERContext>(options =>
                options
                    .UseInMemoryDatabase("ExchangeRateDB") 
            );
        }
    }
}
