using SHP.Messaging.ServiceAudit.Enums;

namespace SHP.Messaging.ServiceAudit.Models
{
    public class UserLoggedInMessage : MessageBase
    {
        public UserLoggedInMessage(string username)
        {
            UserName = username;
        }

        public string UserName { get; set; }

        public override AuditEventCode EventCode { get; } = AuditEventCode.UserLoggedIn;
    }
}
