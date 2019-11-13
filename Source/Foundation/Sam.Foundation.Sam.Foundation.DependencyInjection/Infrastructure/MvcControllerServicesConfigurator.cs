using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.Foundation.Sam.Foundation.DependencyInjection.Infrastructure
{
    public class MvcControllerServicesConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMvcControllers("*.Feature.*");
            serviceCollection.AddClassesWithServiceAttribute("*.Feature.*");

            serviceCollection.AddMvcControllers("*.Foundation.*");
            serviceCollection.AddClassesWithServiceAttribute("*.Foundation.*");

            serviceCollection.AddMvcControllers("*.ATV.*");
            serviceCollection.AddClassesWithServiceAttribute("*.ATV.*");
        }
    }
}