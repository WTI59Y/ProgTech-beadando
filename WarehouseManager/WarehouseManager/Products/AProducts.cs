using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManager.Products
{
    abstract class AProducts
    {
        protected abstract void Wrap();
        protected void Docketing()
        {
            Console.WriteLine("A termék cimkezese ... sikeresen megtörtént.");
        }
        protected void Transport()
        {
            Console.WriteLine("A termék szállítása elkezdődött.");

        }
        protected void Delivery()
        {
            Console.WriteLine("A termék kézbesítése sikeresen megtörtént.");
        }
        public void Generate()
        {
            Wrap();
            Docketing();
            Transport();
            Delivery();
            Console.WriteLine();
        }
        public void Store()
        {
            Console.WriteLine("Egy termék el lett tárolva.");
        }
    }
}
