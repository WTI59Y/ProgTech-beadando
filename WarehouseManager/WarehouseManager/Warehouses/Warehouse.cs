using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Products;

namespace WarehouseManager.Warehouses
{
    abstract class Warehouse
    {
        protected SimpleProductFactory factory;        
        protected int capacity;
        public Warehouse(SimpleProductFactory factory)
        {
            this.factory = factory;
            
        }
        public abstract void SendProduct(string productname);
        public abstract void GetProduct(string productname);
       
    }
}
