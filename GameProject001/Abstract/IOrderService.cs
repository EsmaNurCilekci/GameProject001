using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellerProject001.Abstract
{
    interface IOrderService
    {
        void Order(Seller seller, Customer customer);
        void CampaignOrder(Seller seller, ICustomerService customer, Campaign campaign);
    }
}
