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
        { Product product=new Product
            {
                Name = "coca-cola",
                SKU = "1",
                Description="delicious",
                Count = 20,
                Price = 250
            };
            Product product1 = new Product
            {
                Name = "coca-cola",
                SKU = "2",
                Description="cold",
                Count = 20,
                Price = 250
            };
            ResponsibleWorker worker=new ResponsibleWorker
            {
                Name="Kundyz",
                Position="Operator"
            };
            WareHouse s = new OpenWareHouse();
             Console.WriteLine(s.IsAddProduct(product, 40));
            Console.WriteLine(s.IsAddProduct(product1, 20));
            Console.WriteLine(s.IsMove("1",15,product1,new ClosedWareHouse()));
           s.IsHireResponsibleWorker(worker);
            
            Console.ReadKey();
        }
    }
}
