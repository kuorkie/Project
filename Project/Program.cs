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
            Product t = new BulkProduct
            {
                Name = "coca-cola",
                SKU = "1",
                Description = "Delicious",
                Count = 20,
                Price = 250
            };
            Product l = new Product
            {
                Name = "coca-cola",
                SKU = "2",
                Description = "Delicious",
                Count = 20,
                Price = 250
            };
            
            WareHouse s = new OpenWareHouse1();

            Console.WriteLine(s.IsAddProduct(l, 20));
         
            Console.WriteLine(s.TotalPrice());
            Console.WriteLine(s.IsFindProduct("45"));
            Console.WriteLine(s.IsRemove("2", 20, l));
            Console.ReadKey();
        }
    }
}
