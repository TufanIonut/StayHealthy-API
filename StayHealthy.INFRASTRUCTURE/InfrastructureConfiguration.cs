using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayHealthy.INFRASTRUCTURE
{
    public static class InfrastructureConfiguration
    {
        public static IServiceCollection RegisterPersistanceDependencies (this IServiceCollection services)
        {

            return services;
        }
    }
}
