using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Products;

namespace WarehouseManager.Warehouses
{
    class ElectricWarehouse : Warehouse
    {
        Dictionary<string, bool> storage;
        public ElectricWarehouse(SimpleProductFactory factory)
            : base(factory)
        {
            this.capacity = 150;
            this.storage = new Dictionary<string, bool>();
        }
        public override void SendProduct(string productName)
        {
            if (storage.Count > 0 && storage.ContainsKey(productName))
            {
                ElectricProducts product;
                product = (ElectricProducts)factory.OrderProduct("ElectricProduct", productName);
                product.Generate();
                storage.Remove(productName);
            }
            else
            {
                Console.WriteLine("Jelenleg nincs raktáron a termék!");
            }
        }
        public override void GetProduct(string productName)
        {
            if (storage.Count < capacity)
            {
                ElectricProducts product;
                product = (ElectricProducts)factory.OrderProduct("ElectricProduct", productName);
                product.Store();
                storage.Add(productName, product.IsWireless);
            }
            else
            {
                Console.WriteLine("Nincs elég férőhely a raktárban!");
            }
        }
    }
}
