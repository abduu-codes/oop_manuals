namespace challenge2
{
    public class Product
    {
        public string name;
        public string category;
        public float price;
        public int stock;
        public int minStock;

        public Product(string name, string category, float price, int stock, int minStock)
        {
            this.name = name;
            this.category = category;
            this.price = price;
            this.stock = stock;
            this.minStock = minStock;
        }

        public float CalculateTax()
        {
            if (category.ToLower() == "grocery")
            {
                return price * 0.10f;
            }
            else if (category.ToLower() == "fruit")
            {
                return price * 0.05f; 
            }
            else
            {
                return price * 0.15f;
            }
        }
    }
}