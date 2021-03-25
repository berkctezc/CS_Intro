using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prod1 = new Product();
            prod1.Id = 1;
            prod1.ProductName = "Masa";
            prod1.UnitPrice = 500;
            prod1.UnitsInStock = 3;

            //one line set
            Product prod2 = new Product
            {
                Id = 2,
                ProductName = "Kalem",
                CategoryId = 5,
                UnitsInStock = 5,
                UnitPrice = 35
            };

            //PascalCase    //camelCase
            //case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(prod1);
            productManager.Add(prod2);
        }
    }
}
