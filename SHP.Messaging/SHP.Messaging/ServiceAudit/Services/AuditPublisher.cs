using MassTransit;
using SHP.Messaging.ServiceAudit.Models;
using SHP.Messaging.ServiceAudit.Services.Abstractions;
using System.Threading.Tasks;

namespace SHP.Messaging.ServiceAudit.Services
{
    internal sealed class AuditPublisher : IMessagePublisher
    {
        private readonly IPublishEndpoint _publisher;

        public AuditPublisher(IPublishEndpoint publisher)
        {
            _publisher = publisher;
        }

        public async Task Publish<T>(T message) where T : AuditMessageBase
        {
            await _publisher.Publish(message);
        }
    }
}
