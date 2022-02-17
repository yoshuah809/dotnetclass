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
                if(product.getProduct().Count.Equals(0))
                {
                    Console.WriteLine("There is no product/grocery available");
                    Console.WriteLine("do you want to add any product? press the keyword s/n");

                    option = Console.ReadLine().ToLower();
                    if(option.Equals("s"))
                    {
                        Console.WriteLine("How many products do you want to add?");
                        int qty = Convert.ToInt32(Console.ReadLine());

                        for (int item = 0; item < qty; item++)
                        {
                            Console.WriteLine("New Product");
                            Console.WriteLine("Enter ID");

                            var id= Console.ReadLine();

                            Console.WriteLine("Enter Product Name");
                            var name = Console.ReadLine();

                            Console.WriteLine("Enter The Price");
                            var price = Convert.ToDouble(Console.ReadLine());

                            product.addProduct(new Product{ 
                            ID = id, Name = name, Price = price
                            });
                        }
                        Console.WriteLine("Do you want to go back to Start? press the keyword s/n");
                        option = Console.ReadLine();

                        value = option.Equals("s") ? true : false;
                    }
                    else
                    {
                        Console.WriteLine("Do you go back to the begining? press the keyword s/n");
                        option = Console.ReadLine();
                        if(option.Equals("s"))
                        {
                            Console.Clear();
                            Console.WriteLine("Groceries and Fruit Sales");
                        }
                        else
                        {
                            value = false;
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Groceries and Fruit List");
                    foreach (var item in product.getProduct())
                    {
                        Console.WriteLine($"ID:  {item.ID} Name: {item.Name} Price: {item.Price}");
                    }
                    Console.WriteLine("Do you want to Sale any groceies? press the keyword s/n");
                    option = Console.ReadLine();



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
