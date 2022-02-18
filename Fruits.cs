using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netCoreClass
{
    public class Fruits : Warehouse
    {
        public override void addProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public override List<Product> getProduct(string prod)
        {
            throw new NotImplementedException();
        }
    }
}
