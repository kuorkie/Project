using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class WareHouse : IWareHouse
    {
        public List<Product> Product { get; set; } = new List<Product>();
        public double Square { get; set; }
        public string ResponsibilityWorker { get; set; }
        public Address Address { get; set; }
         public virtual bool IsAddProduct(Product product, int count)
        {
            if (Product.Any(u => u.Name == product.Name)) {
                Product.Where(u => u.Name == product.Name).ToList().ForEach(i => i.Count += count);
                return true;
            }
            else {
                Product.Add(product);
                Product.Where(u => u.Name == product.Name).ToList().ForEach(i => i.Count += count);
                return false; }
        }
        public string IsFindProduct(Product product, string Sku)
        {
            if (Product.Any(u => u.SKU == product.SKU))
            {
                return product.SKU;
            }

            else
            {

                return "Не найден";


            }
        }
        public decimal SumAllofProductPrice()
        {

            decimal z = 0;
            foreach (var i in Product)
            {
                z += i.Price * i.Count;

            }
            return z;
        }
        
        
       
    }
}