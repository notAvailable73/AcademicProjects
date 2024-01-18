using System;

namespace point_of_sale
{
    class Program
    {
        static void Main(string[] args)
        { 
            Admin myadmin = new Admin(); 
            Shop GazipurShop = new Shop("Board Bazar, Gazipur");


            Product product1 = new Product("Laptop","P001", "High-performance laptop", 1200, 10);
            Product product2 = new Product("SmartPhone", "P002", "Foldable", 999, 5);

            myadmin.addProduct(GazipurShop,product1);
            myadmin.addProduct(GazipurShop,product2);

            User user = new User("Mainul", 01796110486);
            myadmin.initiateOrder(GazipurShop, user, "P001", 2);
            


        }
    }
}
