﻿using SHP.Messaging.ServiceAudit.Models;
using System.Threading.Tasks;

namespace SHP.Messaging.ServiceAudit.Services.Abstractions
{
    public interface IMessagePublisher
    {
        Task Publish<T>(T message) where T : AuditMessageBase;
    }
}
