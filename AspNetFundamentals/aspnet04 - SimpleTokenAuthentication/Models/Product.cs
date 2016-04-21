namespace SimpleTokenAuthentication.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

        public Product()
        {
        }

        public Product(int id, string name, string category, decimal price)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
        }
    }
}