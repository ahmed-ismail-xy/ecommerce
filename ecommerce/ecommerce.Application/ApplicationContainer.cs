﻿using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ecommerce.Application
{
    public static class ApplicationContainer
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
