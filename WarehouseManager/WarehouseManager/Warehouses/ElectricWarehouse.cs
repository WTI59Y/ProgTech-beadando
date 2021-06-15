using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Monitor;
using WarehouseManager.Producer_Consumer;
using WarehouseManager.Products;

namespace WarehouseManager.Warehouses
{
    class ElectricWarehouse : Warehouse
    {
        Dictionary<string, ElectricProducts> storage;
        Producer p;

        public ElectricWarehouse(SimpleProductFactory factory)
            : base(factory)
        {
            this.capacity = 150;
            this.storage = new Dictionary<string, ElectricProducts>();
            this.p = new ElectricProducer(this);
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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Jelenleg nincs raktáron ez a termék! ({0})\n", productName);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        public override void GetProduct(string productName)
        { }
        public void GetProduct(string productName, bool isWireless)
        {
            if (storage.Count < capacity)
            {
                ElectricProducts product;
                product = (ElectricProducts)factory.OrderProduct("ElectricProduct", productName);
                product.IsWireless = isWireless;
                product.Store();
                storage.Add(productName, product);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nincs elég férőhely a raktárban!\n");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        public Iterator CreateIterator()
        {
            return new ElectricWarehouseIterator(this.storage);
        }
    }
}
