using BusinessAutomation.Common.Contracts;

namespace BusinessAutomation.Domain.Finance.RequisitionStatuses
{
    public class RequisitionStatus : AuditableEntity, IAggregateRoot
    {
        public required string Name { get; set; }
    }

}
