using MassTransit;
using MassTransit.ExtensionsDependencyInjectionIntegration;
using SHP.Messaging.Options;

namespace SHP.Messaging.Services.RabbitMQ
{
    public class RabbitMqRegistrer : BrokerRegistrer
    {
        public RabbitMqRegistrer(MessagingOptions options) : base(options)
        {

        }
        public override void Register(IServiceCollectionBusConfigurator configurator)
        {
            configurator.UsingRabbitMq((context, config) =>
            {
                config.Host(_options.Connection);
            });
        }
    }
}
