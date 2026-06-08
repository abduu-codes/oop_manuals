using System.Collections.Generic;

namespace challenge2
{
    public class ProductDL
    {
        public static List<Product> products = new List<Product>();

        public static void AddProduct(Product p)
        {
            products.Add(p);
        }
        public static Product GetHighestPriceProduct()
        {
            if (products.Count == 0) 
                return null;

            Product highest = products[0];
            for (int i = 1; i < products.Count; i++)
            {
                if (products[i].price > highest.price)
                {
                    highest = products[i];
                }
            }
            return highest;
        }
        public static Product FindProduct(string name)
        {
            foreach (Product p in products)
            {
                if (p.name == name)
                {
                    return p;
                }
            }
            return null;
        }
    }
}