using WebStore.Sales.Application.Mappers;
using WebStore.Sales.Application.Services;
using WebStore.Sales.Domain.Entities;
using WebStore.Sales.Domain.Interfaces.Application.Mappers;
using WebStore.Sales.Domain.Interfaces.Application.Service;
using WebStore.Sales.Domain.Interfaces.Infra.Data.Repository;
using WebStore.Sales.Infra.Data.Repository;

namespace WebStore.Sales.Presentation.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ISaleService, SaleService>();
            services.AddScoped<IBaseRepository<Sale>, BaseRepository<Sale>>();
            services.AddSingleton<ISaleMapper, SaleMapper>();
        }
    }
}
