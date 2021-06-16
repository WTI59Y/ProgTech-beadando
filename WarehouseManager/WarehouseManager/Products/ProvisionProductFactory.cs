using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManager.Products
{
    class ProvisionProductFactory : SimpleProductFactory
    {
        public Products OrderProduct(string name)
        {
            Products product = new ProvisionProducts(name);
            return product;
        }
    }
}
