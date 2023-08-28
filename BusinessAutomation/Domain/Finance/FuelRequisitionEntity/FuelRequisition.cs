using BusinessAutomation.Common.Contracts;
using BusinessAutomation.Domain.Finance.FuelTypes;
using BusinessAutomation.Domain.Finance.RequisitionStatuses;
using BusinessAutomation.Domain.Finance.VehicleEntity;

namespace BusinessAutomation.Domain.Finance.FuelRequisitionEntity
{
    public class FuelRequisition 
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public required string FuelPurpose { get; set; }
        public int Distance { get; set; }
        public Guid FuelTypeId { get; set; }
        public required FuelType FuelType { get; set; }
        public Guid VehicleId { get; set; }
        public required Vehicle Vehicle { get; set; }
        public Guid RequisitionStatusId { get; set; }
        public required RequisitionStatus Status { get; set; }
        public byte ApprovalsDoneCounter { get; set; }
        public bool IsApproved { get; set; }
        public bool HasRejection { get; set; } = false;
        public bool IsAcquitted { get; set; }
    }

}
