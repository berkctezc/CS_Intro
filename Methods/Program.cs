using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Description = "Amasya elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Description = "Diyarbakır Karpuzu";

           // Product product3 = new("Mango", 150, "Egzotik");


            //urunden olusan dizi, dizinin ismi = dizi {ögeler}
            Product[] products = new Product[] { product1, product2 };

            //       Tip     x in dizi       
            foreach (Product prod in products)
            {
                Console.WriteLine(prod.Name);
                Console.WriteLine(prod.Price);
                Console.WriteLine(prod.Description);
                Console.WriteLine("------");
            }

            Console.WriteLine("--Metotlar--");


            //instance örnek
            //encapsulation
            BasketManager basketManager = new BasketManager();
            basketManager.Add(product2);
            basketManager.Add(product1);

        }
    }
}
