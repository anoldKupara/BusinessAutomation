using BusinessAutomation.Common.Contracts;
using BusinessAutomation.Domain.Finance.FuelRequisitionEntity;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessAutomation.Domain.Finance.VehicleEntity
{
    public class Vehicle : AuditableEntity, IAggregateRoot
    { 
        public required string Name { get; set; }
        public required string RegistrationNumber { get; set; }
        public required string Color { get; set; }
        public required string Mileage { get; set; }


        [ForeignKey("VehicleTypeId")]
        public Guid VehicleTypeId { get; set; }
        public VehicleType? VehicleType { get; set; }


        [ForeignKey("VehicleClassId")]
        public Guid VehicleClassId { get; set; }
        public VehicleClass? VehicleClass { get; set; }

        public virtual ICollection<FuelRequisition>? FuelRequisitions { get; set; }
        public virtual ICollection<VehicleRequisition>? VehicleRequisitions { get; set; }
    }
}
