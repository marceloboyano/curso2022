using Newtonsoft.Json;
using System.Net;

namespace challenge.Config
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
       
        public ExceptionMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<ExceptionMiddleware>();
        }

        public async Task InvokeAsync(HttpContext httpcontext)
        {
            try
            {
                await _next(httpcontext);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Oooops! Algo salió mal: {ex.Message}");
                await HandleGlobalExceptionAsync(httpcontext, ex);
            }
        }

        private static Task HandleGlobalExceptionAsync(HttpContext httpcontext, Exception ex)
        {
            httpcontext.Response.ContentType = "application/json";
            httpcontext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            return httpcontext.Response.WriteAsync(JsonConvert.SerializeObject(new ErrorDetails()
            {
                StatusCode = StatusCodes.Status500InternalServerError,
                MessageProcessingHandler = "Algo salió mal. Error!",
                StackTrace = ex.StackTrace,
            }));            

        }
    }

    
}
