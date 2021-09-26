using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellerProject001.Abstract
{
    interface ICustomerCheckManager
    {
        bool Check(IStoreCheckManager customer);
    }
}
