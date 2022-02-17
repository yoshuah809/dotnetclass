using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netCoreClass
{
    public class Menu : Main, IProduct
    {
        private string s;

        public Menu(string s)
        {
            this.s = s;
            base.getProduct();
        }

        public void addProduct()
        {
            
        }

       

        //protected virtual void getProduct()
        //{
        //    Console.WriteLine(s);
        //}

        
    }

    interface IProduct
    {
        void addProduct();
    }

}
