using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace point_of_sale
{
    public interface IProductAddable
    {
        void addProduct(Shop shop, Product product);
        
    }
}
