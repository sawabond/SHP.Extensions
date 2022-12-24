using MassTransit.ExtensionsDependencyInjectionIntegration;
using SHP.Messaging.Options;

namespace SHP.Messaging.Services
{
    public abstract class BrokerRegistrer
    {
        protected readonly MessagingOptions _options;

        protected BrokerRegistrer(MessagingOptions options)
        {
            _options = options;
        }

        public abstract void Register(IServiceCollectionBusConfigurator configurator);
    }
}
