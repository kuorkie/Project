using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public static class Reporting
    {
        public static void MyExtension1(this WareHouse f, WareHouse o)
        {/*

            var result = f.Product.Join(o.Product, f1 => f1, o1 => o1, (f1, o1) => f1);
            Console.WriteLine(result);

            
            var result = f.Product.Intersect(o.Product).ToList();
            var result1 = (from num in f.Product select num).Intersect(o.Product).ToList();
            foreach(var item in result1)
            {
                Console.WriteLine(item);
            }*/
            var result = f.Product.Select(u => new { u.Name, u.Count ,u.Price,u.SKU,u.Description}).Intersect(o.Product.Select(u => new { u.Name, u.Count, u.Price, u.SKU, u.Description })).ToList();

            foreach (var item in result)
            {
                Console.WriteLine($"Name:{item.Name} Count:{item.Count} Price: {item.Price} SKu: {item.SKU} Description: {item.Description}");
            }
        }
    }
}
