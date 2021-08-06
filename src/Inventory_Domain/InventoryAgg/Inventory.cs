namespace Inventory_Domain.InventoryAgg
{
    public class Inventory
    {
        public long Id { get; private set; }
        public string Product { get; private set; }
        public int UnitPrice { get; private set; }
        public bool IsStock { get; private set; }

        public Inventory(string product, int unitPrice)
        {
            GuardAgainstInvalidProduct(product);
            GuardAgainstInvalidUnitPrice(unitPrice);

            Product = product;
            UnitPrice = unitPrice;
            IsStock = false;
        }

        private static void GuardAgainstInvalidProduct(string product)
        {
            if (string.IsNullOrEmpty(product))
                throw new InvalidProductException();
        }

        private static void GuardAgainstInvalidUnitPrice(int unitPrice)
        {
            if (unitPrice <= 0)
                throw new InvalidUnitPriceException();
        }

    }
}