using System;

namespace netCoreClass
{
    class Program : Menu
    {
       
        
        static void Main(string[] args)
        {
            //instantiate warehouse object
            var obj = new Menu();
            new Program().groceries();

        }

        private void start()
        {
            groceries();
        }

        //protected override void getProduct()
        //{
        //    Console.WriteLine("Santa Claus is comming tonight");
        //}
    }
}
