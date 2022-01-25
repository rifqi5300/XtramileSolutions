using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using XtramileSolutions.Application.Interfaces.Data;
using XtramileSolutions.Infrastructure.Data;

namespace XtramileSolutions.Infrastructure
{
    public static class Injection
    {
        public static IServiceCollection RegisterInfrastructureServices(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<XtramileSolutionDbContext>(options => 
            {
                options.UseSqlServer(configuration.GetConnectionString("XtramileConnString"));
            });

            service.AddScoped<IXtramileSolutionDbContext, XtramileSolutionDbContext>();

            return service;
        }
    }
}
