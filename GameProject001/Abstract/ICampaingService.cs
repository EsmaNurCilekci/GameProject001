using GameProject001.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellerProject001.Abstract
{
  public  interface ICampaingService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void UpDate(Campaign campaign);
    }
}
