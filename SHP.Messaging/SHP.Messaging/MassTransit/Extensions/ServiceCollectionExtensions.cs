using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using SHP.Messaging.Enums;
using SHP.Messaging.Options;
using SHP.Messaging.Services;
using System.ComponentModel;

namespace SHP.Messaging.MassTransit.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddOnlineShopTransit(
            this IServiceCollection services,
            IConfiguration config)
        {
            services.AddOptions<MessagingOptions>().Bind(config.GetSection(MessagingOptions.Messaging));

            var brokerRegistrer = services
                .BuildServiceProvider()
                .CreateScope()
                .ServiceProvider
                .GetRequiredService<BrokerRegistrer>();

            services.AddMassTransit(config =>
            {
                brokerRegistrer.Register(config);
            });

            return services;
        }
    }
}
