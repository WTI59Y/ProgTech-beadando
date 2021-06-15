using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Warehouses;

namespace WarehouseManager.Producer_Consumer
{
    class ElectricProducer : Producer
    {
        public ElectricProducer(ElectricWarehouse warehouse)
            :base(warehouse)
        {
            this.warehouse = warehouse;
        }
        public void Produce(string name, bool isWireless)
        {
            ElectricWarehouse ew = this.warehouse as ElectricWarehouse;
            ew.GetProduct(name, isWireless);
        }
    }
}
