using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager : IOrderService
    {
        public void BuyGame(Game game, Gamer gamer,Campaign campaign)

        {
            int discount = (game.GamePrice * campaign.Discount) / 100;
            Console.WriteLine(game.GameName+" oyunu "+gamer.FirstName+" "+gamer.LastName+" tarafından satın alınmıştır.\nÖdenen Ücret: "+(game.GamePrice-discount)+"\nİndirim tutarı: "+discount+"\nSipariş Tarihi: "+DateTime.Now);
        }
    }
}
