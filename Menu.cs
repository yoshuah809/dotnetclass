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
                if(product.getProduct("").Count.Equals(0))
                {
                    Console.WriteLine("There is no product/grocery available");
                    Console.WriteLine("do you want to add any product? press the keyword y/n");

                    option = Console.ReadLine().ToLower();
                    if(option.Equals("y"))
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
                        Console.WriteLine("Do you want to go back to Start? press the keyword y/n");
                        option = Console.ReadLine();

                        value = option.Equals("y") ? true : false;
                    }
                    else
                    {
                        Console.WriteLine("Do you go back to the begining? press the keyword y/n");
                        option = Console.ReadLine();
                        if(option.Equals("y"))
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
                    foreach (var item in product.getProduct(""))
                    {
                        Console.WriteLine($"ID:  {item.ID} Name: {item.Name} Price: {item.Price}");
                    }
                    Console.WriteLine("Do you want to Sale any groceries? press the keyword y/n");
                    option = Console.ReadLine();

                    if(option.Equals("y"))
                    {
                        sales();
                    }
                    else 
                    {
                        value = false; 
                    }


                }
            } while (value);
        }

        public double RequestPayment()
        {
            bool paymentCorrect = false;
            double response = 0;

            while(!paymentCorrect)
            {
                Console.WriteLine("How you wish to pay, with: 5, 10 ");
                response = double.Parse(Console.ReadLine());

                if (response  !=5 && response !=10)
                {
                    Console.WriteLine("Invalid Payment");
                }
                else {
                    paymentCorrect = true;
                }
            }
            return response;
        }

        public void sales()
        {
            double total = 0;
            string option = "";

            do
            {
                Console.WriteLine("Enter the Product to search");
                string prod = Console.ReadLine();

                var products = product.getProduct(prod);

                while (products.Count.Equals(0))
                {
                    Console.WriteLine("Product Not available, please select a different product");
                    prod = Console.ReadLine();
                    products = product.getProduct(prod);
                    
                }
                Console.WriteLine($"The amount to pay is: {products[0].Price.ToString()} $Dollars ");
                double payment = RequestPayment();

                while (payment < products[0].Price)
                {
                    Console.WriteLine($" ${(products[0].Price - payment).ToString()} is Due");
                    payment += RequestPayment();
                }
                Console.WriteLine($"Your change is:  ${(payment - products[0].Price).ToString()}");
                total += products[0].Price;
                Console.WriteLine($" Your payment was ${total.ToString()}");
                Console.WriteLine("Fo you want to buy something else? y/n?");
                option = Console.ReadLine();


            }
            while (option.Equals("y"));
            
        }
    }



}
