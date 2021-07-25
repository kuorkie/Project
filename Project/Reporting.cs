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
            var result = f.Product.Intersect(o.Product); 
            foreach (var i in result) {
                Console.WriteLine(i); }
            
        }
       public static void MyExtension2(this WareHouse f,WareHouse o)
        {
            var result = f.Product.Select(u=>u.Name).Except(o.Product.Select(u=>u.Name)).FirstOrDefault();
             Console.WriteLine(result);
          foreach(var i in f.Product ) {
                if (result == i.Name)
                {
                    if (i.Count > 1)
                    {
                        o.IsAddProduct(i,i.Count / 2);
                        Console.WriteLine(f.Product.Where(u => u.Name == i.Name).FirstOrDefault().Count -= i.Count/2);
                        
                    }
                }
            }
            
        } 
    }
}
