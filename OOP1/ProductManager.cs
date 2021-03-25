using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+" ürününüz eklenmiştir!");
        }       public void Update(Product product,string yeniad)
        {
            product.ProductName = yeniad;
            Console.WriteLine(product.ProductName+" ürününüz eklenmiştir!");
        }
    }
}
