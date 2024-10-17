using WebStore.Sales.Application.Services;
using WebStore.Sales.Domain.Interfaces.Application.Service;

namespace WebStore.Sales.Presentation.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ISaleService, SaleService>();
        }
    }
}
