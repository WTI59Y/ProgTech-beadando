using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Warehouses;
using WarehouseManager.Products;

namespace WarehouseManager.Monitor
{
    internal class MonitorClass
    {
        ElectricWarehouse ew;
        ProvisionWarehouse pw;

        public MonitorClass(ElectricWarehouse ew, ProvisionWarehouse pw)
        {
            this.ew = ew;
            this.pw = pw;
        }
        public void Update()
        {
            Iterator electricIterator = ew.CreateIterator();
            Iterator provisionIterator = pw.CreateIterator();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Elektronikai raktár készlet:");
            MonitorWrite(electricIterator);
            Console.WriteLine("\nÉlelmiszer raktár készlet:");
            MonitorWrite(provisionIterator);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;

        }

        private void MonitorWrite(Iterator i)
        {
            while(i.HasNext())
            {
                Products.Products product = (Products.Products)i.Next();
                Console.WriteLine(product);
            }
        }

    }
}
