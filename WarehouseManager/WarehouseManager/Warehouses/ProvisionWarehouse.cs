using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Monitor;
using WarehouseManager.Products;

namespace WarehouseManager.Warehouses
{
    class ProvisionWarehouse : Warehouse
    {
        List<Products.Products> storage;
        ProvisionProductFactory provisionFactory;
        public ProvisionWarehouse(ProvisionProductFactory factory)
            :base(factory)
        {
            this.capacity = 50;
            this.storage = new List<Products.Products>();
            this.provisionFactory = factory;
        }
        public override void SendProduct(string productName)
        {
            if (storage.Count > 0)
            {
                ProvisionProducts product;
                product = (ProvisionProducts)provisionFactory.OrderProduct(productName);
                product.Generate();
                storage.RemoveAt(storage.Count - 1);
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Jelenleg nincs raktáron ez a termék! ({0})\n",productName);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        public override void GetProduct(string productName)
        {
            if (storage.Count < capacity)
            {
                ProvisionProducts product;
                product = (ProvisionProducts)provisionFactory.OrderProduct(productName);
                product.Store();
                storage.Add(product);
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
            return new ProvisionWarehouseIterator(storage);
        }
    }
}
