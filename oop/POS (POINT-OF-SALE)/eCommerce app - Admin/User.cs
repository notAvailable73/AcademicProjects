using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace point_of_sale
{
    public class User
    {
        public string Name { get; set; } 
        public double phoneNumber { get; set; }
        public List<Product> orderedProductList;
        public User(string name, double phnNum)
        {
            phoneNumber = phnNum;
            Name = name;
            orderedProductList = new List<Product>();
        }
    }
}
