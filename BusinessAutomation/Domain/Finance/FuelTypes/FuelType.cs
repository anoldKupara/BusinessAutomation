using BusinessAutomation.Common.Contracts;

namespace BusinessAutomation.Domain.Finance.FuelTypes
{
    public class FuelType : AuditableEntity, IAggregateRoot
    {
        public required string Name { get; set; }
    }

}
