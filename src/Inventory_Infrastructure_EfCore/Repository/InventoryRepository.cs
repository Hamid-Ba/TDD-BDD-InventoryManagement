using Inventory_Domain.InventoryAgg;
using Inventory_Infrastructure_EfCore.Context;

namespace Inventory_Infrastructure_EfCore.Repository
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly InventoryContext _context;

        public InventoryRepository(InventoryContext context) => _context = context;

        public void Create(Inventory entity) => _context.Add(entity);

        public void Save() => _context.SaveChanges();
    }
}
