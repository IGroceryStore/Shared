using System;
using MediatR;

namespace IGroceryStore.Shared.Abstractions
{
    public abstract class BaseDomainEvent : INotification
    {
        public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
    }
}