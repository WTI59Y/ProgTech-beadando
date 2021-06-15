using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Products;

namespace WarehouseManager.Monitor
{
    class ElectricWarehouseIterator : Iterator
    {
        Dictionary<string, ElectricProducts> storage;
        int position = 0;

        public ElectricWarehouseIterator(Dictionary<string, ElectricProducts> storage)
        {
            this.storage = storage;
        }
        public bool HasNext()
        {
            if (position >= storage.Count())
                return false;
            return true;
        }

        public Object Next()
        {
            ElectricProducts product = storage[storage.Keys.ToList()[position]];
            position++;
            return product;
        }
    }
}
