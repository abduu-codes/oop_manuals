using System;
using System.Collections.Generic;

public class Customer
{
    public string customerName;
    public string customerAddress;
    public string customerContact;
    public List<Product> products = new List<Product>();
    public Customer(string cName, string cAddress, string cContact)
    {
        customerName = cName;
        customerAddress = cAddress;
        customerContact = cContact;
    }

  
    public void addProduct(Product p)
    {
        products.Add(p);
    }
    public List<Product> getAllProducts()
    {
        return products;
    }

    public float calculateTotalTax()
    {
        float totalTax = 0;

        foreach (Product item in products)
        {
            totalTax = totalTax + item.calculateTax();
        }

        return totalTax;
    }
}