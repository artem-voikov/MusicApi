using Microsoft.AspNetCore.Http;
using MusicApi.Representation.Entities;
using NLog;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace MusicApi
{
    internal class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, ILogger logger)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                logger.Error(ex);

                var response = new VmBaseResponse
                {
                    HttpStatusCode = System.Net.HttpStatusCode.InternalServerError,
                    Message = ex.Message,
                    Title = "Something went wrong"
                };

                await context.Response.WriteAsync(JsonSerializer.Serialize(response));
            }
        }
    }
}