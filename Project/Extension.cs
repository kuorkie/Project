using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    static class Extension
    {
        public static void MyExtension(this WareHouse f, string name)
        {
            string sku = f.Product.Where(u => u.Name == name).FirstOrDefault().SKU;
            if (sku == null)
            {
                Console.WriteLine("failed");
            }
            
                Console.WriteLine(sku);
            
            
        }
        
        public static void  Method1(this WareHouse f)
        {
            var result = f.Product.Where(u => u.Count < 100).OrderBy(u=>u.Name);
            if (result == null)
            {
                Console.WriteLine("failed");
            }
            Console.WriteLine(result);

        }

     
    }
    }
