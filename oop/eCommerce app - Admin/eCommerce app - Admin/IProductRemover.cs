using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce_app___Admin
{
    public interface IProductRemover
    {
        void removeProduct(Shop shop, string productID);
    }
}
