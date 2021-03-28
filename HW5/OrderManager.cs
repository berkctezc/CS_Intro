using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class OrderManager
    {
        public void Sell(Campaign campaign,Order order)
        {
            Console.WriteLine(campaign.CampaignName+" kampanyasından yararlanılarak satış gerçekleşti");
            Console.WriteLine(order.Id+" numaralı sipariş alındı");
        }
        public void Sell(Order order)
        {
            Console.WriteLine("Satış gerçekleşti (kampanya kullanılmadı)");
            Console.WriteLine(order.Id + " numaralı sipariş alındı");
        }
    }
}
