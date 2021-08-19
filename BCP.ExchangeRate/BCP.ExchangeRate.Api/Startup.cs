using BCP.ExchangeRate.Api.Configuration;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Hosting;
using System.Text;

namespace BCP.ExchangeRate.Api
{
    public class Startup
    {

        readonly string AllowSpecification = "Allow";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            var secretKey = Configuration.GetValue<string>("SecretKey");
            var secretKeyinBytes = Encoding.ASCII.GetBytes(secretKey);

            services.AddDbContext();

            services.AddRouting(options =>
            {
                options.LowercaseUrls = true;
            });

            services.AddApiVersioning(o =>
            {
                o.ReportApiVersions = true;
                o.AssumeDefaultVersionWhenUnspecified = true;
                o.DefaultApiVersion = new ApiVersion(1, 0);
            });

            services.AddCors(options =>
            {
                options.AddPolicy(AllowSpecification, builder =>
                {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyHeader();
                    builder.AllowAnyMethod();
                });

            });

            services.AddHealthChecks()
              .AddCheck("self", () => HealthCheckResult.Healthy());

            services.AddControllers();

            services.ConfigureAutoMapper();
            services.ConfigureSwagger();
            services.ConfigureServices();
            services.ConfigureAuthentication(secretKeyinBytes);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(AllowSpecification);

            app.ConfigurationExceptionHandler();

            app.UseRouting();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHealthChecks("/health", new HealthCheckOptions()
                {
                    Predicate = _ => true,
                    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
                });
            });
        }
    }
}
