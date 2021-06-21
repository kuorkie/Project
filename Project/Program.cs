using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main()
        {
            {
                Name = "coca-cola",
                SKU = "1",
                Count = 20,
                Price = 250
            };
            Product l = new Product
            {
                Name = "coca-cola",
                SKU = "2",
                Count = 20,
                Price = 250
            };
            
            WareHouse s = new OpenWareHouse1();

            Console.WriteLine(s.IsAddProduct(l, 20));
            
            Console.ReadKey();
        }
    }
}
