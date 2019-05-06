using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS
{
   public static class DIExtensions
    {

        public static IServiceCollection AddEventPublisher(this IServiceCollection services)
        {
            services.AddScoped<IEventPublisher, ServiceBusPublisher>();
            return services;
        }
    }
}
