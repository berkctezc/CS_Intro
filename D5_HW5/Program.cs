using System;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new UserValidationManager());
            playerManager.Add(new Player
            {
                Id = 1,
                BirthYear = 1998,
                //BirthYear=1997 --> kayit basarisiz
                FirstName = "Berkcan",
                LastName = "Tezcaner",
                IdentityNumber = "12345"
            });
            //hatalı giris
            playerManager.Add(new Player
            {
                Id = 1,
                BirthYear = 1998,
                FirstName = "Berk",
                LastName = "Tezcaner",
                IdentityNumber = "12345"
            });

            Campaign campaign1 = new Campaign { CampaignName = "Yeni Yıl İndirimi", Id = 1, SalePercent = 25 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign1);
            campaignManager.Update(campaign1);
            Console.WriteLine("--");

            Order order1 = new Order { Id = 1, Price = 100};
            Order order2 = new Order { Id = 1, Price = 200 };

            OrderManager orderManager = new OrderManager();

            orderManager.Sell(order1);

            Console.WriteLine("--");

            orderManager.Sell(campaign1,order2);
        }
    }
}
