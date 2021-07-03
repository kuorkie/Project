using System;


namespace Project
{
    public interface IWareHouse
    {
       bool IsAddProduct(Product product, int count);
       decimal TotalPrice();
       string FindProduct( string Sku);
        bool IsMove(int count,Product product,IWareHouse warehouse);
        void HireResponsibleWorker(ResponsibleWorker worker);
        void Print();
    }
}
    

  