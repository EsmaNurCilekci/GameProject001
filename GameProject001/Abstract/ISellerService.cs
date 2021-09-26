using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellerProject001.Abstract
{
    interface ISellerService
    {
        void Add(Seller seller);
        void Delete(Seller seller);
        void Update(Seller seller);
    }
}
