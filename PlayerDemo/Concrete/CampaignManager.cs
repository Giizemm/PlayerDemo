using System;
using System.Collections.Generic;
using System.Text;
using PlayerDemo.Abstract;
using PlayerDemo.Entities;

namespace PlayerDemo.Concrete
{
    public class CampaignManager : ICampaign
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " kampanyası eklendi.");
        }

        public void CalculateDiscountRate(Campaign campaign)
        {
            Console.WriteLine(campaign.DiscountRate + " indirimli fiyatı hesaplandı.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " kampanyası silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " kampanyası gündellendi.");
        }
    }
}
