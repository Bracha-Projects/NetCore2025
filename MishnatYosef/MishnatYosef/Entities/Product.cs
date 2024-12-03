namespace MishnatYosef.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Category { get; set; }
        public int Image { get; set; }
        public string Comments { get; set; }

        public Product(int id, string productName, string description, double price, int category, int image, string comments)
        {
            Id = id;
            ProductName = productName;
            Description = description;
            Price = price;
            Category = category;
            Image = image;
            Comments = comments;
        }

        public Product()
        {
            
        }

    }
}
