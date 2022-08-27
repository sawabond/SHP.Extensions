using SHP.Messaging.Enums;

namespace SHP.Messaging.Options
{
    public class MessagingOptions
    {
        public const string Messaging = "Messaging";

        public BrokerType Broker { get; set; }

        public string Connection { get; set; }
    }
}
