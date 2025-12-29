using TEST.Domain;
using TEST.Infrastructure;

namespace TEST.API
{
    public static class Startup
    {
        public static IServiceCollection InjectStartUpDI(this IServiceCollection service)
        {
            service.InjectInfraDI();
            return service;
        }
    }
}
