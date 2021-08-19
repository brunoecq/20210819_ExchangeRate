
using BCP.ExchangeRate.Domain.Dtos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Net;

namespace BCP.ExchangeRate.Api.Configuration
{
    public static class GlobalExceptionConfiguration
    {

        public static void ConfigurationExceptionHandler(this IApplicationBuilder app)
        {

            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {

                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";
                    var contextFeature = context.Features.Get<IExceptionHandlerPathFeature>();

                    await context.Response.WriteAsync(JsonConvert.SerializeObject(new ExceptionResponseDto
                    {
                        Message = contextFeature.Error.Message,
                        StackTrace = contextFeature.Error.StackTrace
                    }));

                });

            });
        }
    }
}
