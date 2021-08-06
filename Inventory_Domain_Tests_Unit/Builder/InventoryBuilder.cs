using Inventory_Domain.InventoryAgg;

namespace Inventory_Domain_Tests_Unit.Builder
{
    public class InventoryBuilder
    {
        private string _product;
        private int _unitPrice;

        public InventoryBuilder WriteProduct(string product)
        {
            _product = product;
            return this;
        }

        public InventoryBuilder WriteUnitPrice(int unitPrice)
        {
            _unitPrice = unitPrice;
            return this;
        }

        public Inventory Build() => new(_product, _unitPrice);
    }
}
