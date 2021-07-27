﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public static class Reporting
    {
        public static void CountLessThan3(this WareHouse f)
        {
            var result = f.Product.Where(u => u.Count < 3).OrderBy(u => u.Count);
            if (result == null)
            {
                Console.WriteLine("failed");
            }
            foreach (var i in f.Product.Where(u => u.Count < 3).OrderBy(u => u.Count))
            {
                Console.WriteLine(i.Count);

            }

        }
        public static void First3Max(this WareHouse f)
        {
            var result = f.Product.OrderBy(u => u.Count).Reverse().Take(3);
            foreach (var i in result)
            {
                Console.WriteLine(i.Name);

            }


        }
        public static void SpecialProduct(this WareHouse f)
        {
            var result = f.Product.Distinct().OrderBy(u => u.Name);
            foreach (var i in result)
            {
                Console.WriteLine(i.Name);
            }
        }
        public static void NoBulkProduct(this List<WareHouse> f)
        {
            

            bool result = f.All(u => !(u.Product is BulkProduct));
           
            Console.WriteLine(result);
          
        }

        public static void ArifProduct(this WareHouse f,WareHouse o)
        {
            var result = f.Product.Concat(o.Product).GroupBy(u => u.Name);
           
          foreach(var i in result)
            {
                var result1 = i.Average(u => u.Count);

                Console.WriteLine($"Name: {i.Key} Count:{result1}");
                
            }
          
            
        }
        
    }
        }
    

