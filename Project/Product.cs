using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Product
    {public string Name { get; set; }
     public string SKU { get; set; }

     public string Description { get;set;}

        internal static object Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        public int Count { get; set; }

    public decimal Price { get; set; }

        

    }
   
}
