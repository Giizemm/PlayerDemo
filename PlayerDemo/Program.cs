using System;
using PlayerDemo.Abstract;
using PlayerDemo.Concrete;
using PlayerDemo.Entities;

namespace PlayerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IEntityService entityService = new PlayerManager();
            entityService.Add(new Player(){FirstName = "Gizem",LastName = "Ünal"});
            entityService.Add(new Player(){FirstName = "Abdullah",LastName = "Zengin"});
            entityService.Delete(new Player(){FirstName = "Gizem"});
            
            Console.WriteLine("--------------------------------");
            
            IGame game = new GameManager();
            game.Add(new Game(){GameName = "Mobile legends",GameType = "Strateji"});
            game.Add(new Game() { GameName = "Sudoku", GameType = "Zeka-Mantık" });
            game.Delete(new Game(){GameName = "Mobile Legends"});

            Console.WriteLine("--------------------------------");

            game.SaleGame(new Game(){GameName = "Mobile Legends"},new Player(){FirstName = "Abdulah"});
            game.Campaigns(new Game(){GameName = "Sudoku"},new Campaign(){Name = "Kara Cuma"});

            Console.WriteLine("--------------------------------");

            ICampaign campaign = new CampaignManager();
            campaign.Add(new Campaign(){Id = 1,DiscountRate = "%50",Name = "Yılbaşı İndirimi"});
            campaign.Add(new Campaign() { Id = 2, DiscountRate = "%60", Name = "Kara Cuma İndirimi" });
            campaign.Delete(new Campaign(){Name = "Yılbaşı İndirimi"});
            campaign.CalculateDiscountRate(new Campaign(){DiscountRate = "%60"});
            
        }
    }
}
