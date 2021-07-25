﻿using System;
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
                Count = 1,
                Price = 250
            };
            Product product1 = new DimensionProduct
            {
                Name = "sprite",
                SKU = "256",
                Description="cold",
                Count = 2,
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
           
            
             /*   
            Console.WriteLine("Выберите тип склада:Открытый или Закрытый\n");
            string type=Console.ReadLine();
            Console.WriteLine("1.Добавить товар  ");
            Console.WriteLine("2.Переместить товар");
            Console.WriteLine("3.Информация о товаре");
            Console.WriteLine("4.Назначить ответственого работника");
            Console.WriteLine("5.Общая цена\n");

            

                        string method =Console.ReadLine();
                        if (type == "Открытый" )

                        {
                          WareHouse o = new OpenWareHouse();
                            o.Notify += (sender, e) =>
                              Console.WriteLine(" Получено сообщение о добавление товара" + e.NameofProduct+" "+e.DateTime);
                            Console.WriteLine(o.IsAddProduct(product1, 40));


                            o.HireResponsibleWorker(worker1);
                            switch (method) { 
                               case "1":
                         Console.WriteLine(o.IsAddProduct(product, 40)); break;
                               case "2":

                            Console.WriteLine(o.IsMove(15,product1,new ClosedWareHouse()));break;


                            case "3":
                                o.Print(); break;
                            case "4":
                                o.HireResponsibleWorker(worker1);break;
                           case "5":
                               Console.WriteLine( o.TotalPrice()); break;



                            }
                        }
                          if (type == "Закрытый" )

                        {
                          WareHouse f = new ClosedWareHouse();

                            Console.WriteLine(f.IsAddProduct(product1, 1));
                            Console.WriteLine(f.IsAddProduct(product, 1));
                            f.Notify += (sender, e) =>
                              Console.WriteLine(" Получено сообщение о добавление товара" + e.NameofProduct);
                            switch (method) { 
                               case "1":
                         Console.WriteLine(f.IsAddProduct(product1, 10));

                                    break;
                               case "2":

                            Console.WriteLine(f.IsMove(20,product1,new OpenWareHouse()));
                                   break;


                            case "3":
                                f.Print(); break;
                            case "4":
                                f.HireResponsibleWorker(worker1);break;
                           case "5":
                                Console.WriteLine(f.TotalPrice());break;
                                case "6":
                                    f.MyExtension("sprite"); break;
                                case "7":
                                    f.MyExtension1(new OpenWareHouse());break;
                            }
                        }
                       */
            WareHouse o = new OpenWareHouse();
           
            Console.WriteLine(o.IsAddProduct(product1, 40));
            WareHouse f = new ClosedWareHouse();
            Console.WriteLine(o.IsAddProduct(product1, 80));
            Console.WriteLine(f.IsAddProduct(product, 100));
            f.MyExtension1(o);
            f.MyExtension2(o);
            Console.ReadKey();
        }
       
    }
}
