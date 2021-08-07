using System;
using Inventory_Application_Contract.InventoryAgg;

namespace Inventory_Presentation_Tests_Integration.Utils
{
    public static class Utils
    {
        public static InventoryDefineVM SomeCreateCode() => new()
        {
            Product = new Guid().ToString(),
            UnitPrice = new Random().Next(500, 10000)
        };
    }
}