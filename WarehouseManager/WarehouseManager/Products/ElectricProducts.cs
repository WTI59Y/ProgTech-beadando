using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManager.Products
{
    class ElectricProducts : AProducts
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private bool isWireless;
        public bool IsWireless     
        {
            get { return isWireless; }
            set { isWireless = value; }
        }
        public ElectricProducts(string name, bool isWireless)
        {
            this.name = name;
            this.isWireless = isWireless;
        }
        protected override void Wrap()
        {
            Console.WriteLine("A törékeny műszaki cikk becsomagolása buborék fóliába...");
            Console.WriteLine("A csomagolt műszaki cikk dobozba helyezése...");
            Console.WriteLine("A műszaki cikk becsomagolása sikeresen megtörtént");
        }
        
    }
}
