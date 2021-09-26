using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject001.Consrete
{
    class OrderSManager : IOrderService
    {

        public void CampaignOrder(Seller seller, Customer cutomer, Campaign campaign)


    decimal indirimOranı = seller.Sellerprice - (seller.SellerkPrice * campaign.DiscountRate);
        Console.WriteLine("Sayın" + customer.FirtsName + " " + customer.LastName + " " + campaign.CampaignName + " " + seller.Seller + " : Ürününü" + indirimOranı + "TL' ye Satın Aldınız");
 
        public void Order(Seller seller, Customer customer)
        {
            Console.WriteLine(customer.FirtName + " "+ customer.LastName + "Satın Aldı : " + seller.SellerName + " " +seller.SellerPrice + " TL");
        }


    }
}
