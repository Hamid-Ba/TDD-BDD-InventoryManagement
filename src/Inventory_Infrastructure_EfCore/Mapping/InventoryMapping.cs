using Inventory_Domain.InventoryAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventory_Infrastructure_EfCore.Mapping
{
   public class InventoryMapping : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Product).HasMaxLength(150).IsRequired();
        }
    }
}
