using Microsoft.Extensions.DependencyInjection;

namespace BlazorLogger
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddJavascriptLogger(this IServiceCollection services)
        {
            return services.AddSingleton<ILogger, Logger>();
        }
    }
}
