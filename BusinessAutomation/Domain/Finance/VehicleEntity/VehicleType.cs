using BusinessAutomation.Common.Contracts;

namespace BusinessAutomation.Domain.Finance.VehicleEntity
{
    public class VehicleType : AuditableEntity, IAggregateRoot
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
    }

}
