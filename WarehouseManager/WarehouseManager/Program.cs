using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Products;
using WarehouseManager.Warehouses;
using WarehouseManager.Monitor;

namespace WarehouseManager
{
    class Program
    {
        static void Main(string[] args)
        {
            WarehouseManager wm = new WarehouseManager();
            wm.ProduceElectrics("Porszívó", true);
            wm.ProduceElectrics("Monitor", false);

            wm.ConsumeElectrics("Monitor");
            wm.ConsumeProvisions("Kenyér");

            Console.ReadKey();
        }
    }
}
