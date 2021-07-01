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
            Product product1 = new BulkProduct
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
                if (method == "1") { 
             Console.WriteLine(o.IsAddProduct(product, 40));}
                 if (method == "2")
                {Console.WriteLine(o.IsMove("1",15,product1,new ClosedWareHouse()));

                }
                 if(method == "3")
                {
                    o.Print();
                }
                if (method == "4")
                {
                    o.IsHireResponsibleWorker(worker);
                }
                if (method== "5")
                {
                    o.TotalPrice();
                }
            }
              if (type == "Закрытый" )

            {
              WareHouse f = new ClosedWareHouse();
                Console.WriteLine(f.IsAddProduct(product, 40));
                if (method == "1") { 
             Console.WriteLine(f.IsAddProduct(product, 150));}
                 if (method == "2")
                {Console.WriteLine(f.IsMove("1",15,product1,new OpenWareHouse()));

                }
                 if(method == "3")
                {
                    f.Print();
                }
                if (method == "4")
                {
                    f.IsHireResponsibleWorker(worker);
                }
                if (method== "5")
                {
                    f.TotalPrice();
                }
            }

           
            Console.ReadKey();
        }
    }
}
