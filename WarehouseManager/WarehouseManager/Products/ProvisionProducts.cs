using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManager.Products
{
    class ProvisionProducts : AProducts
    {
        protected override void Wrap()
        {
            Console.WriteLine("Az élelmiszer bedobozolása elkezdődött...");
            Console.WriteLine("Az élelmiszer becsomagolása sikeresen megtörtént.");
        }
    }
}
