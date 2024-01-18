using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace point_of_sale
{
    public interface IProductPriceUpdatable
    {
        void updateProductPrice(Shop shop, string productID, Decimal price);
    }
}
