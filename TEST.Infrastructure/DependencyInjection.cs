using Microsoft.Extensions.DependencyInjection;

namespace TEST.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection InjectInfraDI(this IServiceCollection service)
        {
            return service;
            // Configuration code here
        }
    }
}
