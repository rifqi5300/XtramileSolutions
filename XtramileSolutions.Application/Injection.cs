using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using XtramileSolutions.Application.Interfaces.Logics;
using XtramileSolutions.Application.Implementations.Logics;

namespace XtramileSolutions.Application
{
    public static class Injection
    {
        public static IServiceCollection RegisterApplicationServices(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddScoped<ICountryLogics, CountryLogics>();
            service.AddScoped<ICityLogics, CityLogics>();
            service.AddScoped<IGeneralLogics, GeneralLogics>();

            return service;
        }
    }
}
