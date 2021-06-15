using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Monitor;
using WarehouseManager.Producer_Consumer;
using WarehouseManager.Products;
using WarehouseManager.Warehouses;

namespace WarehouseManager
{
    class WarehouseManager
    {
        
        ElectricWarehouse ew;
        ProvisionWarehouse pw;
        MonitorClass monitor;
        ElectricProducer electricProducer;
        ProvisionProducer provisionProducer;
        Consumer consumer;

        public WarehouseManager()
        {
            this.ew = new ElectricWarehouse(new SimpleProductFactory());
            this.pw = new ProvisionWarehouse(new SimpleProductFactory());
            this.monitor = new MonitorClass(this.ew, this.pw);
            this.electricProducer = new ElectricProducer(this.ew);
            this.provisionProducer = new ProvisionProducer(this.pw);
            this.consumer = new Consumer(this.ew, this.pw);
        }
        public void ProduceElectrics(string name, bool isWireless)
        {
            electricProducer.Produce(name, isWireless);
            monitor.Update();
        }
        public void ProduceProvisions(string name)
        {
            provisionProducer.Produce(name);
            monitor.Update();
        }

        public void ConsumeElectrics(string name)
        {
            consumer.ConsumeElectrics(name);
            monitor.Update();
        }
        public void ConsumeProvisions(string name)
        {
            consumer.ConsumeProvisions(name);
            monitor.Update();
        }
    }
}
