namespace Inventory_Domain.InventoryAgg
{
    public interface IInventoryRepository
    {
        void Create(Inventory entity);
        void Save();
    }
}