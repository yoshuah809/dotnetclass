using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netCoreClass
{
    public class Menu : IMenu
    {
        Warehouse product = new Groceries();
        public void groceries()
        {
            var option = "";
            var value = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Groceries Sale");
                if(product.getProduct().Count == 0)
                {
                    Console.WriteLine("There is no product/grocery available");
                    Console.WriteLine("do you want to add any product? press the keyword s/n");

                    option = Console.ReadLine();
                    if(option.Equals("s"))
                    {
                        Console.WriteLine("How many product do you want to add?");
                        int qty = Convert.ToInt32(Console.ReadLine());
                    }
                }
            } while (value);
        }

        public double RequestPayment()
        {
            throw new NotImplementedException();
        }

        public void sales()
        {
            throw new NotImplementedException();
        }
    }



}
