using SellerProject001.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject001.Consrete
{
    class CustomerCheckManager:ICustomerCheckService
    {
        ICustomerCheckManager_customerCheckService;

       public bool Check (Customer customer)
        {
            _customerCheckService = new MernisServiceAdapter();
            return_customerCheckService.Check(customer);
        }
    }
}
