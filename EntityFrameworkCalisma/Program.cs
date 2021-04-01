using System;

namespace EntityFrameworkCalisma
{
    class Program
    {
        static void Main(string[] args)
        {
            //EF - ORM: Object Relational Mapping

            Console.WriteLine("Hello World!");
        }
    }

    public class Product
    {
        public int ProductId { get; set; } //PK
        public int CategoryId { get; set; } //FK
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; } //smalint
    }

    public class NorthwindContext : DbContext
    {

    }
}
