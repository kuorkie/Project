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
        { Product product=new BulkProduct
            {
                Name = "coca-cola",
                SKU = "1",
                Description="delicious",
                Count = 20,
                Price = 250
            };
            Product product1 = new DimensionProduct
            {
                Name = "coca-cola",
                SKU = "2",
                Description="cold",
                Count = 20,
                Price = 250
            };
            ResponsibleWorker worker1=new ResponsibleWorker
            {
                Name="Kundyz",
                Position="Operator"
            };
          Address address=new Address
          {
              City="Busan",
              Country="South Korea"
          };
            Console.WriteLine("Выберите тип склада:Открытый или Закрытый\n");
            string type=Console.ReadLine();
            Console.WriteLine("1.Добавить товар  ");
            Console.WriteLine("2.Переместить товар");
            Console.WriteLine("3.Информация о товаре");
            Console.WriteLine("4.Назначить ответственого работника");
            Console.WriteLine("5.Общая цена\n");

            string method=Console.ReadLine();
            if (type == "Открытый" )

            {
              WareHouse o = new OpenWareHouse();
              Console.WriteLine(o.IsAddProduct(product1, 40));  
                switch (method) { 
                   case "1":
             Console.WriteLine(o.IsAddProduct(product, 40)); break;
                   case "2":
                Console.WriteLine(o.IsAddProduct(product1, 40));
                Console.WriteLine(o.IsMove("1",15,product1,new ClosedWareHouse()));break;

                
                case "3":
                    o.Print(); break;
                case "4":
                    o.IsHireResponsibleWorker(worker1);break;
               case "5":
                   Console.WriteLine( o.TotalPrice()); break;

                
            }}
              if (type == "Закрытый" )

            {
              WareHouse f = new ClosedWareHouse();
               Console.WriteLine(f.IsAddProduct(product1, 40));
               switch (method) { 
                   case "1":
             Console.WriteLine(f.IsAddProduct(product1, 40)); break;
                   case "2":
                Console.WriteLine(f.IsAddProduct(product1, 40));
                Console.WriteLine(f.IsMove("2",15,product1,new OpenWareHouse()));break;

                
                case "3":
                    f.Print(); break;
                case "4":
                    f.IsHireResponsibleWorker(worker1);break;
               case "5":
                    Console.WriteLine(f.TotalPrice());break;

                
            }
            }

           
            Console.ReadKey();
        }
    }
}
