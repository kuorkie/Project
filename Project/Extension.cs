using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    static class Extension
    {
        public static void  MyExtension(this Product product,string name)
        {
            if (product.Name == name)
            {
                Console.WriteLine( product.SKU);
            }

        }
    }
}
