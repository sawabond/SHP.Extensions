using SHP.Messaging.ServiceAudit.Enums;
using System;

namespace SHP.Messaging.ServiceAudit.Models
{
    public abstract class AuditMessageBase
    {
        public DateTime Time { get; } = DateTime.UtcNow;

        public virtual AuditEventCode EventCode { get; } = AuditEventCode.Undefined;
    }
}
