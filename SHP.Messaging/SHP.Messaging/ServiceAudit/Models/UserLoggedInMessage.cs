using SHP.Messaging.ServiceAudit.Enums;

namespace SHP.Messaging.ServiceAudit.Models
{
    public sealed class UserLoggedInMessage : AuditMessageBase
    {
        public UserLoggedInMessage(string username)
        {
            UserName = username;
        }

        public string UserName { get; set; }

        public override AuditEventCode EventCode { get; } = AuditEventCode.UserLoggedIn;
    }
}
