using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Products;

namespace WarehouseManager.Warehouses
{
    class ProvisionWarehouse : Warehouse
    {
        List<AProducts> storage;
        public ProvisionWarehouse(SimpleProductFactory factory)
            :base(factory)
        {
            this.capacity = 50;
            this.storage = new List<AProducts>();
        }
        public override void SendProduct(string productName)
        {
            if (storage.Count > 0)
            {
                ProvisionProducts product;
                product = (ProvisionProducts)factory.OrderProduct("ProvisionProduct", productName);
                product.Generate();
                storage.RemoveAt(storage.Count - 1);
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
                ProvisionProducts product;
                product = (ProvisionProducts)factory.OrderProduct("ProvisionProduct", productName);
                product.Store();
                storage.Add(product);
            }
            else
            {
                Console.WriteLine("Nincs elég férőhely a raktárban!");
            }
        }

    }
}
