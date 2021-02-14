using GameProject.Entities;
using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignService : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("{0} Campaign Added!",campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("{0} Campaign Updated!", campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("{0} Campaign Deleted!", campaign.CampaignName);
        }
    }
}
