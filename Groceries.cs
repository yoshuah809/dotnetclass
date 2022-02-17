using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netCoreClass
{
    public class Groceries : Warehouse
    {
        public override void addProduct(Product product)
        {
            
        }

        public override List<Product> getProduct(string value)
        {
            throw new NotImplementedException();
        }
    }
}
