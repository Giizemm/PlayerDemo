using System;
using System.Collections.Generic;
using System.Text;
using PlayerDemo.Entities;

namespace PlayerDemo.Abstract
{
    public interface ICampaign
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);

        void Update(Campaign campaign);
        void CalculateDiscountRate(Campaign campaign);
    }
}
