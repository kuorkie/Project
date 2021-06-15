using System;


namespace Project
{
    public  interface IWareHouse
    {
       bool IsAddProduct(Product product, int count);
       decimal TotalPrice();
       string IsFindProduct( string Sku);
        bool IsRemove(string Sku,int count,Product product);
    }
}
    

  