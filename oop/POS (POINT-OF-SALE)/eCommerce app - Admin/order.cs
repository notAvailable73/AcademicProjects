using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace point_of_sale
{
    public class order
    {
        public int id;
        public User user;
        public Product product;
        public int quantity;
        public order(User user, Product product, int quantity)
        {
            this.user = user;
            this.product = product;
            this.quantity = quantity;
        }
    }
}
