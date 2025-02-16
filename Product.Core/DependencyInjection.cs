using Microsoft.Extensions.DependencyInjection;
using Product.Core.IServices;
using Product.Core.Services;


namespace Product.Core
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {

            services.AddScoped<IProductServices, ProductServices>();
            return services;
        }

    }


}


