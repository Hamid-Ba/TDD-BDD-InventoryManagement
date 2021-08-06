﻿using System;
using Inventory_Application_Contract.InventoryAgg;

namespace Inventory_Application_Tests_Unit.Utils
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