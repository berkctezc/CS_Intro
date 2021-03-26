using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer cust1 = new IndividualCustomer();
            cust1.CustomerNo = "12345";
            cust1.Name = "Berkc";
            cust1.Surname = "Tezc";
            cust1.Surname = "1111";
            cust1.Id = 1;

            CorporateCustomer cust2 = new CorporateCustomer();
            cust2.CompanyName = "BT";
            cust2.CustomerNo = "1221";
            cust2.Id = 2;
            cust2.TaxNo = "2142";

            Customer cust4 = new IndividualCustomer();
            Customer cust5 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(cust1);
            customerManager.Add(cust2);
        }
    }
}