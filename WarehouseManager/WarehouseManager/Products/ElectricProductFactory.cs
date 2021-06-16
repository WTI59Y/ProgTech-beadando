using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManager.Products
{
    class ElectricProductFactory : SimpleProductFactory
    {
        public Products OrderProduct(string name, bool isWireless)
        {
            Products product = new ElectricProducts(name, isWireless);
            return product;
        }
        public Products OrderProduct(string name)
        {
            Products product = new ElectricProducts(name, false);
            return product;
        }
    }
}
