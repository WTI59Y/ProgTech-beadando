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
        ElectricProductFactory electricFactory;

        public ElectricWarehouse(ElectricProductFactory factory)
            : base(factory)
        {
            this.capacity = 150;
            this.storage = new Dictionary<string, ElectricProducts>();
            this.p = new ElectricProducer(this);
            this.electricFactory = factory;
        }
        public void SendProduct(string productName, bool isWireless)
        {
            if (storage.Count > 0 && storage.ContainsKey(productName))
            {
                ElectricProducts product;
                product = (ElectricProducts)electricFactory.OrderProduct(productName, isWireless);
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
        public override void SendProduct(string productName)
        {
            if (storage.Count > 0 && storage.ContainsKey(productName))
            {
                ElectricProducts product;
                product = (ElectricProducts)electricFactory.OrderProduct(productName, false);
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
        {
            if (storage.Count < capacity)
            {
                ElectricProducts product;
                product = (ElectricProducts)electricFactory.OrderProduct(productName, false);
                product.Store();

                string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                StringBuilder articleNo = new StringBuilder();
                Random rnd = new Random();

                for (int i = 0; i < 12; i++)
                {
                    articleNo.Append(chars[rnd.Next(chars.Length)]);
                }

                storage.Add(articleNo.ToString(), product);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nincs elég férőhely a raktárban!\n");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        public void GetProduct(string productName, bool isWireless)
        {
            if (storage.Count < capacity)
            {
                ElectricProducts product;
                product = (ElectricProducts)electricFactory.OrderProduct(productName, isWireless);
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
