using System;


namespace Project
{
    public interface IWareHouse
    {
       bool IsAddProduct(Product product, int count);
       decimal SumAllofProductPrice();
       string IsFindProduct(Product product, string Sku);
    }
}
    

  