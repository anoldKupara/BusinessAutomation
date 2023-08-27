using BusinessAutomation.Common.Contracts;
using BusinessAutomation.Domain.Finance.RequisitionStatuses;

namespace BusinessAutomation.Domain.Finance.VehicleEntity
{
    public class VehicleRequisition : AuditableEntity, IAggregateRoot
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid RequisitionStatusId { get; set; }
        public required RequisitionStatus Status { get; set; }
        public Guid VehicleId { get; set; }
        public required Vehicle Vehicle { get; set; }
        public byte ApprovalsDoneCounter { get; set; }
        public bool IsApproved { get; set; }
        public bool HasRejection { get; set; }
        public bool IsAcquitted { get; set; }
        public Guid ApplicantId { get; set; }
    }
}
