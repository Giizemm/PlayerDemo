using System;
using System.Collections.Generic;
using System.Text;
using PlayerDemo.Entities;

namespace PlayerDemo.Abstract
{
    public interface IEntityService
    {
        void Add(Player player);
        void Delete(Player player);
        void Update(Player player);
    }
}
