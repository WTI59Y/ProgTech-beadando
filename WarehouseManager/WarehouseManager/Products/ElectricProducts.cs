using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManager.Products
{
    class ElectricProducts : AProducts
    {

        private bool isWireless;
        public bool IsWireless     
        {
            get { return isWireless; }
            set { isWireless = value; }
        }
        public ElectricProducts(string name, bool isWireless)
        {
            this.Name = name;
            this.isWireless = isWireless;
        }
        protected override void Wrap()
        {
            Console.WriteLine("A törékeny {0} becsomagolása buborék fóliába...", this.Name);
            Console.WriteLine("A csomagolt {0} dobozba helyezése...", this.Name);
            Console.WriteLine("A(z) {0} becsomagolása sikeresen megtörtént", this.Name);
        }

        public override string ToString()
        {
            return string.Format("{0} ", (this.isWireless ? "Vezeték nélküli" : "Vezetékes")) + base.ToString();
        }
    }
}
