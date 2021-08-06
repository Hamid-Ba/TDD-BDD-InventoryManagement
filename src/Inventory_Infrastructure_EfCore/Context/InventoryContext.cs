using Inventory_Domain.InventoryAgg;
using Inventory_Infrastructure_EfCore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Inventory_Infrastructure_EfCore.Context
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(InventoryMapping).Assembly;

            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
        }

        #region DataSets

        public DbSet<Inventory> Inventories { get; set; }

        #endregion
    }
}
