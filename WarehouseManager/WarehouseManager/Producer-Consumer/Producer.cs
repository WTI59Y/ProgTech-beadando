using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Warehouses;

namespace WarehouseManager.Producer_Consumer
{
    abstract class Producer
    {
        protected Warehouse warehouse;

        public Producer(Warehouse warehouse)
        {
            this.warehouse = warehouse;
        }

        public void Produce(string name)
        {
            this.warehouse.GetProduct(name);
        }

    }
}
