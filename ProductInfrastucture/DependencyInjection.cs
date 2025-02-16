using Microsoft.Extensions.DependencyInjection;
using Product.Core.IRepository;
using ProductInfrastucture.Repository;

namespace ProductInfrastucture
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCoree(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }
    }
}
