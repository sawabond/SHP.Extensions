using Microsoft.Extensions.DependencyInjection;
using SHP.Messaging.ServiceAudit.Services;
using SHP.Messaging.ServiceAudit.Services.Abstractions;

namespace SHP.Messaging.ServiceAudit.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAuditPublisher(this IServiceCollection services)
        {
            services.AddScoped<IMessagePublisher, AuditPublisher>();

            return services;
        }
    }
}
