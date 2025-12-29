using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace TEST.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection InjectApplicationDI(this IServiceCollection service)
        {
            return service;
            // Configuration code here
        }
    }
}
