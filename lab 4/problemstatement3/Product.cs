using System;
public class Product
{
    public string name;
    public string category;
    public float price;
    public Product(string pName, string pCategory, float pPrice)
    {
        name = pName;
        category = pCategory;
        price = pPrice;
    }
    public float calculateTax()
    {
        return price * 0.10f;
    }
}