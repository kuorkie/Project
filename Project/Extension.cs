using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public static class Extension
    {
        public static string FindSKU(this WareHouse f, string name)
        {
            string sku = f.Product.Where(u => u.Name == name).FirstOrDefault().SKU;
            if (sku == null)
            {
                return "failed";
            }

            return sku;
            
            
        }
        public static void InTwoWareHouse(this WareHouse f, WareHouse o)
        {

            
           var result = f.Product.Intersect(o.Product).ToList();

            foreach (var i in result)
            {
                Console.WriteLine(i.Name);
            }

        }
        public static void MoveHalfProduct(this WareHouse f, WareHouse o)
        {
            var result = f.Product.Select(u => u.Name).Except(o.Product.Select(u => u.Name)).FirstOrDefault();
            Console.WriteLine(result);
            foreach (var i in f.Product)
            {
                if (result == i.Name)
                {
                    if (i.Count > 1)
                    {
                        o.IsAddProduct(i, i.Count / 2);
                        Console.WriteLine(f.Product.Where(u => u.Name == i.Name).FirstOrDefault().Count -= i.Count / 2);

                    }
                }
            }

        }


     
    }
    }
