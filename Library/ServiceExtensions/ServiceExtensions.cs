using Microsoft.Extensions.DependencyInjection;

namespace Library.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static void AddBackend(this IServiceCollection services)
        {
            services.AddSingleton<IBackend, Backend>();
        }
    }
}
