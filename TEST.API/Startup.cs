using TEST.Application;
using TEST.Infrastructure;

namespace TEST.API
{
    public static class Startup
    {
        public static IServiceCollection InjectStartUpDI(this IServiceCollection service)
        {
            service.InjectApplicationDI()
                .InjectInfraDI();
            return service;
        }
    }
}
