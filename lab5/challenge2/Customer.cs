using System;
using System.Collections.Generic;

namespace challenge2
{
    public class Customer
    {
        public List<Product> cartProducts = new List<Product>();
        public List<int> cartQuantities = new List<int>();

        public void AddToCart(Product p, int quantity)
        {
            cartProducts.Add(p);
            cartQuantities.Add(quantity);
        }
    }
}