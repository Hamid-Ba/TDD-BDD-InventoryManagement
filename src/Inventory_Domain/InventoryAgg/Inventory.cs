namespace Inventory_Domain.InventoryAgg
{
    public class Inventory
    {
        public string Product { get; set; }
        public int UnitPrice { get; set; }


        public Inventory(string product, int unitPrice)
        {
            GuardAgainstInvalidProduct(product);
            GuardAgainstInvalidUnitPrice(unitPrice);

            Product = product;
            UnitPrice = unitPrice;
        }

        private void GuardAgainstInvalidProduct(string product)
        {
            if (string.IsNullOrEmpty(product))
                throw new InvalidProductException();
        }
        
        private void GuardAgainstInvalidUnitPrice(int unitPrice)
        {
            if (unitPrice <= 0)
                throw new InvalidUnitPriceException();
        }

    }
}