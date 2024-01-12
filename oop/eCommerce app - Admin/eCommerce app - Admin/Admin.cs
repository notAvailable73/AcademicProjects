using System;

namespace eCommerce_app___Admin
{
    public class Admin : IAccount, IProductAdder, IProductRemover, IProductUpdater
    {
        public string userName { get; set; }
        public string ID { get; set; }
        public string password { get; set; }

        public void addProduct(Shop shop, Product product)
        {
            shop.AddProduct(product);
        }
        public void removeProduct(Shop shop, string productID)
        {
            shop.RemoveProduct(productID);
        }

        public void updateProductPrice(Shop shop, string productID, Decimal price)
        {
            shop.updateProductPrice(productID, price);
         
        }
        public void updateProductInventory(Shop shop, string productID, int qantity)
        {
            shop.updateProductInventory(productID, qantity);
        }

        public void initiateOrder(Shop shop, User user, string productID, int quantity)
        {
            if (!shop.isProductAvailable(productID))
            {
                Console.WriteLine("This product is not available in this shop.");
            }
            else if (!shop.hasEnoughStock(productID, quantity)) 
            {
                Console.WriteLine("Low inventory.");
            }
            else
            {
                shop.completeOrder(user, productID, quantity);
                
                Console.WriteLine("Order  Initiated Successfully.");
            }
        }
    }
}
