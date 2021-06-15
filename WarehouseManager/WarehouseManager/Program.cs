using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Products;
using WarehouseManager.Warehouses;

namespace WarehouseManager
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectricWarehouse ew = new ElectricWarehouse(new SimpleProductFactory());
            ew.GetProduct("Porszívó");
            ew.SendProduct("Porszívó");
            

            ProvisionWarehouse pw = new ProvisionWarehouse(new SimpleProductFactory());
            pw.GetProduct("Kenyér");
            pw.SendProduct("Kenyér");


            Console.ReadKey();
        }
    }
}
