using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Warehouses;

namespace WarehouseManager.Producer_Consumer
{
    class Consumer
    {
        ElectricWarehouse ew;
        ProvisionWarehouse pw;

        public Consumer(ElectricWarehouse ew, ProvisionWarehouse pw)
        {
            this.ew = ew;
            this.pw = pw;
        }

        public void ConsumeElectrics(string name)
        {
            this.ew.SendProduct(name);
        }

        public void ConsumeProvisions(string name)
        {
            this.pw.SendProduct(name);
        }
    }
}
