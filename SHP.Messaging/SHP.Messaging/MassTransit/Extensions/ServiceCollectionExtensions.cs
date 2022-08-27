using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using SHP.Messaging.Enums;
using SHP.Messaging.Options;
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

            var messagingOptions = services
                .BuildServiceProvider()
                .CreateScope()
                .ServiceProvider
                .GetRequiredService<IOptions<MessagingOptions>>().Value;

            services.AddMassTransit(config =>
            {
                switch (messagingOptions.Broker)
                {
                    case BrokerType.RabbitMQ:
                        config.UsingRabbitMq((context, config) =>
                        {
                            config.Host(messagingOptions.Connection);
                        });
                        break;
                    default:
                        throw new InvalidEnumArgumentException();
                }
            });

            return services;
        }
    }
}
