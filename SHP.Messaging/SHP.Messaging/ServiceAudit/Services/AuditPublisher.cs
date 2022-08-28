using MassTransit;
using SHP.Messaging.ServiceAudit.Models;
using SHP.Messaging.ServiceAudit.Services.Abstractions;
using System.Threading.Tasks;

namespace SHP.Messaging.ServiceAudit.Services
{
    internal class AuditPublisher : IMessagePublisher
    {
        private readonly IPublishEndpoint _publisher;

        public AuditPublisher(IPublishEndpoint publisher)
        {
            _publisher = publisher;
        }

        public async Task Publish<T>(T message) where T : MessageBase
        {
            await _publisher.Publish(message);
        }
    }
}
