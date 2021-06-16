using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManager.Products
{
    class SimpleProductFactory
    {
        public Products OrderProduct(string type, string name)
        {
            Products product = null;
            if (type == "ElectricProduct")
            {
                product = new ElectricProducts(name, false);
            }
            else if (type == "ProvisionProduct")
            {
                product = new ProvisionProducts(name);
            }
            return product;
        }
    }
}
