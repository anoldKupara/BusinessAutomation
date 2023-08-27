using BusinessAutomation.Common.Contracts;

namespace BusinessAutomation.Domain.Finance.VehicleEntity
{
    public class VehicleClass : AuditableEntity, IAggregateRoot
    {
        public required string Name { get; set; }
        public required string FuelConsumption { get; set; }
    }

}
