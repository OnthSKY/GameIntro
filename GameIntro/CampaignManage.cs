using System;
using System.Collections.Generic;

namespace GameIntro
{
    class CampaignManage : ICampaignService
    {
        List<Campaign> campaigns;
        public CampaignManage()
        {
            campaigns = new List<Campaign>() {  };

        }
        public List<Campaign> Campaigns
        {
            get { return campaigns; }
            private set { campaigns = value; }
        }

        public void Add(Campaign campaign)
        {
            campaigns.Add(campaign);
            Console.WriteLine("{0} açıklamalı Kampaya eklenmiştir.",campaign.Explanation);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("{0} numaralı Kampaya silinmiştir.", campaign.Id);
            campaigns.Remove(campaign);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya detayları güncellenmiştir.");
        }
    }
}
