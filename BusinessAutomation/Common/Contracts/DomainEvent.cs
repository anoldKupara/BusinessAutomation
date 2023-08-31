using BusinessAutomation.Shared.Events;

namespace BusinessAutomation.Common.Contracts
{
    public abstract class DomainEvent : IEvent
    {
        public DateTime TriggeredOn { get; protected set; } = DateTime.UtcNow;
    }
}
