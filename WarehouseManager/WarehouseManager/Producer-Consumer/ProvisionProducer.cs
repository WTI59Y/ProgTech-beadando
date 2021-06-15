using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Warehouses;

namespace WarehouseManager.Producer_Consumer
{
    class ProvisionProducer : Producer
    {
        public ProvisionProducer(Warehouse warehouse)
            : base(warehouse)
        {
            this.warehouse = warehouse;
        }
    }
}
