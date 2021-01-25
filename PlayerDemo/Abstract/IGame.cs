using System;
using System.Collections.Generic;
using System.Text;
using PlayerDemo.Entities;

namespace PlayerDemo.Abstract
{
   public  interface IGame
   {
       void Add(Game game);
       void Delete(Game game);
       void SaleGame(Game game,Player player);

       void Campaigns(Game game,Campaign campaign);
   }
}
