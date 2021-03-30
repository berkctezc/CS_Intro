using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqCalisma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
           {
               new Category{CategoryId=1,CategoryName="Bilgisayar"},
               new Category{CategoryId=1,CategoryName="Telefon"},
           };

            List<Product> products = new List<Product>
           {
               new Product{ProductId=1,CategoryId=1,ProductName="Acer Laptop",QuantityPerUnit="32 GB Ram", UnitPrice=10000,UnitsInStock=5},
               new Product{ProductId=2,CategoryId=1,ProductName="Asus Laptop",QuantityPerUnit="16 GB Ram", UnitPrice=8000,UnitsInStock=3},
               new Product{ProductId=3,CategoryId=1,ProductName="HP Laptop",QuantityPerUnit="8 GB Ram", UnitPrice=6000,UnitsInStock=2},
               new Product{ProductId=4,CategoryId=2,ProductName="Samsung Telefon",QuantityPerUnit="4 GB Ram", UnitPrice=5000,UnitsInStock=15},
               new Product{ProductId=5,CategoryId=2,ProductName="Apple Telefon",QuantityPerUnit="4 GB Ram", UnitPrice=8000,UnitsInStock=0},
           };


            //Bazı Linq Komutları

            //Where: şartları saglayan var mı? list dondurur
            var result1 = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);
            foreach (var a in result1)
                Console.WriteLine(a.ProductName);

            Console.WriteLine("*****");

            //Any: bu deger var mı? return bool
            var result2= products.Any(p => p.ProductName == "Acer Laptop");
            Console.WriteLine(result2);

            Console.WriteLine("*****");

            //Find: aranılan bir spesifik elemanı getirir (list). yoksa null döner
            var result3 = products.Find(p => p.ProductName == "Asus Laptop");
            Console.WriteLine(result3.ProductName);

            Console.WriteLine("*****");

            //FindAll: aranılan birçok elemanı getirir. yoksa null döner
            var result4 = products.FindAll(p => p.ProductName.Contains("Laptop"));
            ListPrint(result4);

            Console.WriteLine("*****");

            //OrderBy:UnitPrice için sırala OrderBy:asc OrderByDescending:desc
            var result5 = products.Where(p => p.ProductName.Contains("top")).OrderBy(p=>p.UnitPrice);
            foreach (var a in result5)
                Console.WriteLine(a.ProductName);



        }

        private static void ListPrint(List<Product> list)
        {
            foreach (var a in list)
                Console.WriteLine(a.ProductName);
        }
    }
}
