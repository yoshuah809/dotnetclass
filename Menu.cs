using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netCoreClass
{
    public class Menu 
    {
        private string s;

        public Menu(string s)
        {
            this.s = s;
           
        }

        public void addProduct()
        { }


    }
        interface IProduct
        {
            void addProduct();
        }
    

}
