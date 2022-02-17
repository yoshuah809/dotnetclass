using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netCoreClass
{
    public abstract class Warehouse
    {
        public abstract List<Product> getProduct();

        public abstract void addProduct(Product product);
        
    }
}
