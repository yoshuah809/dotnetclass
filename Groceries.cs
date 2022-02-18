using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netCoreClass
{
    public class Groceries : Warehouse
    {
        private List<Product> Grocery_List;
        public Groceries()
        {
            Grocery_List = new List<Product>();
        }
        public override void addProduct(Product product)
        {
            Grocery_List.Add(product);
        }

        public override List<Product> getProduct(string prod)
        {
            var groceries = new List<Product>();
            if (prod.Equals(""))
            {
                groceries = Grocery_List;
            }
            else
            {
                groceries = Grocery_List.Where(p => p.Name.Equals(prod)).ToList();
            }
            return groceries;
        }
    }
}
