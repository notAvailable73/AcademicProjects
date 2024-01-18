using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace point_of_sale
{
    public class Product
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Description { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
        public Product(string name,string id, string description, decimal price, int quantity)
        {
            Name = name;
            ID= id;
            Description = description;
            this.price = price;
            this.quantity = quantity;
        }

    }
}
