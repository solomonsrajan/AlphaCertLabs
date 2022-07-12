using CanWeFixItApplication.Contracts;
using CanWeFixItApplication.Contracts.Persistence;
using CanWeFixItPersistence.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanWeFixItPersistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IDatabaseService, DatabaseService>();
            services.AddScoped<IInstrumentRepository, InstrumentRepository>();
            services.AddScoped<IMarketDataRepository, MarketDataRepository>();

            return services;
        }
    }
}
