
using GameProject001.Entities;
using SellerProject001.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject001.Consrete
{
    class CustomerManager:ICustomerService
    {
        ICustomerCheckManager _customerCheckManager;
     public CustomerManager(ICustomerCheck customerCheckService)
        {
    _customerCheckManager= customerCheckService
        }
        public void Add(Customer customer )
        {
            if (_customerCheckManager.Check(gamer)==true)
            {
                Console.WriteLine("BAŞARILI");
                Console.WriteLine(customer.UserName + " : Musteri Eklendi ");
            }
            else
            {
                Console.WriteLine("GOOD BYE");
            }
            public void Delete(Customer customer)
            {
                Console.WriteLine(customer.UserName + ": Musteri Silindi");
            }

            public void UpDate(Customer customer)
            {
                if (_customerCheckManager.Check(customer)== true)
                {
                    Console.WriteLine("BAŞARILI");
                    Console.WriteLine(customer.UserName +": Musteri Güncellendi");

                }
                else
                {
                    Console.WriteLine("Güncelleme Başarısız");
                }
            }
        }
    }
}
