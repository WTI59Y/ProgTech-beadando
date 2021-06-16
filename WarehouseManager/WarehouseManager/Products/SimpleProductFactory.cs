using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManager.Products
{
    interface SimpleProductFactory
    {
        Products OrderProduct(string name);
    }
}
