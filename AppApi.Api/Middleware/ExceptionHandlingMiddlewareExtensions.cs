namespace ApiPrayaga.Api.Middleware
{
    public static class ExceptionHandlingMiddlewareExtensions
    {
        public static IApplicationBuilder UseGlobalExceptionErrorHandler(this IApplicationBuilder app) 
            => app.UseMiddleware<ExceptionMiddleware>();
    }
}
