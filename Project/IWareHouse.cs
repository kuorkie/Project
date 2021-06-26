using System;


namespace Project
{
    public interface IWareHouse
    {
       bool IsAddProduct(Product product, int count);
       decimal TotalPrice();
       string IsFindProduct( string Sku);
        bool IsMove(string Sku,int count,Product product,IWareHouse warehouse);
        void IsHireResponsibleWorker(ResponsibleWorker worker);
        void Print();
    }
}
    

  