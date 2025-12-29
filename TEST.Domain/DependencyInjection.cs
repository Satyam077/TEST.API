using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace TEST.Domain
{
    public static class DependencyInjection
    {
        public static IServiceCollection InjectDomainDI(this IServiceCollection service)
        {
            return service;
            // Configuration code here
        }
    }
}
