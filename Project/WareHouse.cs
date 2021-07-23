using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public abstract class WareHouse : IWareHouse
    {
        public List<Product> Product { get; set; } = new List<Product>();
        public double Square { get; set; }
        public ResponsibleWorker Worker { get;set;}
        public Address Address { get; set; }

        public virtual event EventHandler<EventArgs> Notify = delegate { };
         public virtual bool IsAddProduct(Product product, int count)
        {
            if (Product.Any(u => u.Name == product.Name)) {
                var result=Product.Where(u => u.Name == product.Name).FirstOrDefault();
                result.Count+=count;
                Console.WriteLine( result.Count);
              
                
            }
            else {
                Product.Add(product);
                var result =Product.Where(u => u.Name == product.Name).FirstOrDefault();
                result.Count += count;
                Console.WriteLine(result.Count);
                
                }
            
            Notify.Invoke(this, new EventArgs {  NameofProduct = product.Name });
            return true;
        }
        public string FindProduct(string Sku){
            if(Product.Any(u=>u.SKU==Sku)){return Sku;
            }

            else
            {

                return "Не найден";


            }
        }
        public decimal TotalPrice(){

            var result=Product.Sum(u=>u.Count*u.Price);
            return result;
        }
        
        public virtual  bool IsMove(int count,Product product,IWareHouse warehouse)
        {
            if (Product.Any(u => u.Name == product.Name)&&Product.Where(u => u.Name == product.Name).FirstOrDefault().Count>=count)
            {if(warehouse.IsAddProduct(product, count)) 
                Product.Where(u => u.Name == product.Name).FirstOrDefault().Count-=count;
               
             Console.WriteLine("Товар перемещен");
               
                return true;
            }
            else { Console.WriteLine("Товар не найден");
                return false; }
        
        }
        public void HireResponsibleWorker( ResponsibleWorker worker)
        { 
            Worker=worker;
            
           
                  }
       
          
        
           public void Print()
           { Console.WriteLine("Products:");
          foreach( var p in Product) { 
            Console.WriteLine($"Name:{p.Name}");
            Console.WriteLine($"SKU:{p.SKU}");
            Console.WriteLine($"Description:{p.Description}");
            Console.WriteLine($"Count:{p.Count}");
            Console.WriteLine($"Price:{p.Price}");
            }
            Console.WriteLine("Worker:");
            Console.WriteLine($"Responsible Worker:{Worker.Name}");
            Console.WriteLine($"Position:{Worker.Position}");
            Console.WriteLine("Address:");
        Console.WriteLine($"City:{Address.City}");
            Console.WriteLine($"Country:{Address.Country}");
           
        }
    }
    }
    
