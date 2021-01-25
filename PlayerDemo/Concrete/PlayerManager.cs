using System;
using System.Collections.Generic;
using System.Text;
using PlayerDemo.Abstract;
using PlayerDemo.Entities;

namespace PlayerDemo.Concrete
{
    public class PlayerManager : IEntityService
    {
        public void Add(Player player)
        {
            Console.WriteLine(" {0} Kaydınız eklenmiştir.", player.FirstName);
        }

        public void Delete(Player player)
        {
            Console.WriteLine(" {0} kaydın silinmiştir.", player.FirstName);
        }

        public void Update(Player player)
        {
            Console.WriteLine(" {0} kaydın güncellenmiştir.", player.FirstName);
        }
    }
}
