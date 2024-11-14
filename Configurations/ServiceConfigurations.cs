using JobVault.Services.Implementations;
using JobVault.Services.Interfaces;

namespace JobVault.Configurations
{
    public static class ServiceConfigurations
    {
        internal static IServiceCollection AddCustomServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ICandidateInfoServices, CandidateInfoServices>();
            return services;
        }
    }
}
