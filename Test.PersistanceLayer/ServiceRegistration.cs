using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.ApplicationLayer.Services;
using Test.PersistanceLayer.Services;

namespace Test.PersistanceLayer
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddPersistanceService(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            return services;
        }
    }
}
