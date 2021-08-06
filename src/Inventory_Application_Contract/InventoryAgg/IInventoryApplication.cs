namespace Inventory_Application_Contract.InventoryAgg
{
    public interface IInventoryApplication
    {
        bool Define(InventoryDefineVM command);
    }
}
