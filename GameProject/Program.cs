using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1984, FirstName = "Sabri", LastName = "ÖZBEK", IdentityNumber = 12345678911 });

            OrderManager order = new OrderManager();
            order.BuyGame(new Game{ GameName = "Rainbow Six Siege", GameId = 1, GameCategory = "Action", GamePrice = 100 } ,new Gamer { Id = 1, BirthYear = 1984, FirstName = "Sabri", LastName = "ÖZBEK", IdentityNumber = 12345678911 }
            ,new Campaign {CampaignName="/ Black Friday Discount /",CampaignId=1,Discount=20 });

        
        }
    }
}
