using GameProject001.Entities;
using SellerProject001.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject001.Consrete
{
    class CampaingManager:ICampaingService
    {
        public void Add(Campaign campaign)
         {
        Console.WriteLine("Kampanya Eklendi: " + campaign.CampaignName);
         }

     

        public void Delete(Campaign campaign)
          {
        Console.WriteLine("Kampanya Silindi: " + campaign.CampaignName);
         }

      
        public void UpDate(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi: " + campaign.CampaignName);
        }

    }

       

      
    }
}
