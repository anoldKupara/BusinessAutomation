using BusinessAutomation.Domain.Finance.Currencies;
using BusinessAutomation.Domain.Finance.Expenses;
using BusinessAutomation.Domain.Finance.FuelRequisitionEntity;
using BusinessAutomation.Domain.Finance.FuelTypes;
using BusinessAutomation.Domain.Finance.RequisitionStatuses;
using BusinessAutomation.Domain.Finance.VehicleEntity;
using BusinessAutomation.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BusinessAutomation.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<FuelRequisition> FuelRequisitions { get; set; }
        public DbSet<RequisitionStatus> RequisitionStatuses { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleClass> VehicleClasses { get; set; }
        public DbSet<VehicleRequisition> VehicleRequisitions { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<FuelType> FuelType { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}