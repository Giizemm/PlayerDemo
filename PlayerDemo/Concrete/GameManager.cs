using System;
using System.Collections.Generic;
using System.Text;
using PlayerDemo.Abstract;
using PlayerDemo.Entities;

namespace PlayerDemo.Concrete
{
    public class GameManager : IGame
    {
        public void Add(Game game)
        {
            Console.WriteLine("{0} isimli oyun eklenmiştir", game.GameName);
        }

        public void Campaigns(Game game, Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " kampanyası " + game.GameName + " oyunu için geçerlidir.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("{0} isimli oyun silinmiştir.", game.GameName);
        }

        public void SaleGame(Game game)
        {
            Console.WriteLine("{0} isimli oyunu satın aldınız.", game.GameName);
        }

        public void SaleGame(Game game, Player player)
        {
            Console.WriteLine(player.FirstName+ "  " + game.GameName +" oyunu satın almıştır.");
        }
    }
}
