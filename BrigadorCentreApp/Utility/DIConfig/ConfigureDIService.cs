using Microsoft.Extensions.DependencyInjection.Extensions;
using BrigadorCentreApp.Data.Repository;
using BrigadorCentreApp.Data.Repository.IRepository;
using BrigadorCentreApp.Models;
//using BrigadorCentreApp.Service;

using BrigadorCentreApp.Utility.AppSettingClasses;

namespace BrigadorCentreApp.Utility.DIConfig
{
    public static class ConfigureDIService
    {
        public static IServiceCollection AddAllServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}