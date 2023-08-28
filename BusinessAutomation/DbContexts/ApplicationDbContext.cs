using BusinessAutomation.Domain.Finance.FuelRequisitionEntity;
using BusinessAutomation.Domain.Finance.RequisitionStatuses;
using BusinessAutomation.Domain.Finance.VehicleEntity;
using Microsoft.EntityFrameworkCore;
using BusinessAutomation.Domain.Finance.FuelTypes;

namespace BusinessAutomation.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) 
        { 
        }
        public DbSet<FuelRequisition> FuelRequisitions { get; set; }
        public DbSet<RequisitionStatus> RequisitionStatuses { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleClass> VehicleClasses { get; set; }
        public DbSet<VehicleRequisition> VehicleRequisitions { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<BusinessAutomation.Domain.Finance.FuelTypes.FuelType> FuelType { get; set; } = default!;
    }
}
