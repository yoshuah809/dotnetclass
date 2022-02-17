using System;

namespace netCoreClass
{
    class Program: Menu
    {
       
        public Program (string s) : base(s)
        {   
            
        }
        static void Main(string[] args)
        {
           
            Console.ReadKey();
            new Program("Company: Sales Itnl LLC");      

        }

        //protected override void getProduct()
        //{
        //    Console.WriteLine("Santa Claus is comming tonight");
        //}
    }
}
