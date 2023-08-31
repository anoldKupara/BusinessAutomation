using BusinessAutomation.Common.Contracts;

namespace BusinessAutomation.Domain.Finance.RequisitionStatuses
{
    public class RequisitionStatus //: AuditableEntity, IAggregateRoot
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
    }
}
