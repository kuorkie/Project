using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    static class Extension
    {
        public static void  MyExtension(this Product s , string name)
        {
            string sku = Product.Where(u => u.Name == name).FirstOrDefault().SKU;
            Console.WriteLine(sku);
        }
    }
}
