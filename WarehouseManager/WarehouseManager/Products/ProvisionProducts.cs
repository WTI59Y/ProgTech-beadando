using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManager.Products
{
    class ProvisionProducts : AProducts
    {
        public ProvisionProducts(string name)
        {
            this.Name = name;
        }
        protected override void Wrap()
        {
            Console.WriteLine("A(z) {0} bedobozolása elkezdődött...", this.Name);
            Console.WriteLine("A(z) {0} becsomagolása sikeresen megtörtént.", this.Name);
        }
    }
}
