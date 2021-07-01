using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class OpenWareHouse:WareHouse

    {
        public override bool IsAddProduct(Product product, int count)
        {
            if(!(product is BulkProduct))
            {
                base.IsAddProduct(product, count);
                return true;
            }
            else
            {
                try
                { if(product is BulkProduct)
                    {
                        throw new Exception("Сыпущие продукты в Открытом складе");
                    }
                 
                }
                catch(Exception e)
                {
                      Console.WriteLine($"Ошибка:{e.Message}");
                }
                
                return false;
            }

        }
    }

}
