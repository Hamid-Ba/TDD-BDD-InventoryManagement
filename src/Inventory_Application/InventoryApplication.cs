using Inventory_Application_Contract.InventoryAgg;
using Inventory_Domain.InventoryAgg;

namespace Inventory_Application
{
    public class InventoryApplication : IInventoryApplication
    {
        private readonly IInventoryRepository _repository;

        public InventoryApplication(IInventoryRepository repository) => _repository = repository;

        public bool Define(InventoryDefineVM command)
        {
            var inventory = new Inventory(command.Product, command.UnitPrice);
            _repository.Create(inventory);
            _repository.Save();

            return true;
        }
    }
}
