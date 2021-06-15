using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManager.Products
{
    abstract class AProducts
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected abstract void Wrap();
        protected void Docketing()
        {
            Console.WriteLine("A(z) {0} cimkezese ... sikeresen megtörtént.", this.name);
        }
        protected void Transport()
        {
            Console.WriteLine("A(z) {0} szállítása elkezdődött.", this.name);

        }
        protected void Delivery()
        {
            Console.WriteLine("A(z) {0} kézbesítése sikeresen megtörtént.", this.name);
        }
        public void Generate()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Wrap();
            Docketing();
            Transport();
            Delivery();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
        }
        public void Store()
        {
            Console.WriteLine("Egy termék el lett tárolva. ({0})\n",this.name);
        }

        public override string ToString()
        {
            return string.Format("{0}",this.name);
        }
    }
}
