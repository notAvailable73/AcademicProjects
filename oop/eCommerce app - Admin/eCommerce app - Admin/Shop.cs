using System;
using System.Collections.Generic;
using System.Linq;

namespace eCommerce_app___Admin
{
    public class Shop
    {
        public string location;
        public Shop(string location)
        {
            this.location = location;
        }
        private List<Product> productList = new List<Product>();
        private List<order> orderList = new List<order>();
        private Product GetProductByID(string productID)
        {
            foreach (var item in productList)
            {
                if (productID == item.ID)
                {
                    return item;
                }
            }
            return null;
        }
        public void AddProduct(Product product)
        {
            productList.Add(product);
        }
        public void RemoveProduct(string productID)
        {
            Product product = GetProductByID(productID);
            if (product!=null)
            {
                productList.Remove(product);
                Console.WriteLine("Product Removed successfully");
                return;
            }
            Console.WriteLine("Product is not available in this shop.");
        }
        public void updateProductPrice(string productID, decimal price)
        {
            foreach (var item in productList)
            {
                if (productID == item.ID)
                {
                    item.price = price;
                    Console.WriteLine("Updated price successfully.");
                    return;
                }
            }
            Console.WriteLine("Product is not available in this shop.");
        }
        public void updateProductInventory(string productID, int qantity)
        {
            foreach (var item in productList)
            {
                if (productID == item.ID)
                {
                    item.quantity = qantity;
                    Console.WriteLine("Updated Inventory successfully.");
                    return;
                }
            }
            Console.WriteLine("Product is not available in this shop.");
        }
        public bool isProductAvailable(string productID)
        {
            Product product = GetProductByID(productID);
            if (product != null)
            {
                return true;
            }
            return false;
        }
        public bool hasEnoughStock(string productID, int quantity)
        {
            Product product = GetProductByID(productID);
            if (product != null && product.quantity>=quantity)
            {
                return true;
            }
            return false;
        }
        public void completeOrder(User user, string productID, int quantity)
        {
            foreach (var item in productList)
            {
                if (productID == item.ID)
                {
                    item.quantity -= quantity;
                    user.orderedProductList.Add(item);
                    order newOrder = new order(user,item,quantity);
                    orderList.Add(newOrder);
                }
            }
        }
    }
}
