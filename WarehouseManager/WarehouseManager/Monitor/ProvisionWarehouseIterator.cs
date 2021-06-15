using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Products;

namespace WarehouseManager.Monitor
{
    class ProvisionWarehouseIterator : Iterator
    {
        List<AProducts> storage;
        int position = 0;

        public ProvisionWarehouseIterator(List<AProducts> storage)
        {
            this.storage = storage;
        }
        public bool HasNext()
        {
            if (position >= storage.Count() || storage[position] == null)
                return false;
            return true;
        }

        public Object Next()
        {
            ProvisionProducts product = (ProvisionProducts)storage[position];
            position++;
            return product;
        }
    }
}
