using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce_app___Admin
{
    public class User
    {
        public string Name { get; set; } 
        public string phoneNumber { get; set; }
        public List<Product> orderedProductList;
        public User(string name, string phnNum)
        {
            phoneNumber = phnNum;
            Name = name;
            orderedProductList = new List<Product>();
        }
    }
}
