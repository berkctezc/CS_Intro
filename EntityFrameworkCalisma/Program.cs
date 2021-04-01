using System;
using System.Linq;

namespace EntityFrameworkCalisma
{
    class Program
    {
        static void Main(string[] args)
        {
            //EF - ORM: Object Relational Mapping

            GetAll();

            GetProductsByCategory(2);

        }

        private static void GetProductsByCategory(int categoryId)
        {
            NorthwindContext northwindContext = new NorthwindContext();

            var result = northwindContext.Products.Where(p => p.CategoryId == categoryId);

            foreach (var prod in result)
            {
                Console.WriteLine(prod.ProductName);
            }
        }

        private static void GetAll()
        {
            NorthwindContext northwindContext = new NorthwindContext();

            foreach (var prod in northwindContext.Products)
            {
                Console.WriteLine(prod.ProductName);
            }
        }
    }
}
