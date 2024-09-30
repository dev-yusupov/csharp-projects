public class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>()
        {
            new Product {Name = "iPhone", Category="Phone", Price=1399},
            new Product {Name = "iPad", Category="Tablet", Price=1299},
            new Product {Name = "Macbook", Category="Computer", Price=1699},
            new Product {Name = "Mac Studio", Category = "Computer", Price=2499},
            new Product { Name = "Smartphone", Category = "Electronics", Price = 800 },
            new Product { Name = "Tablet", Category = "Electronics", Price = 600 },
            new Product { Name = "Headphones", Category = "Electronics", Price = 200 },
        };

        var expensiveProducts = products
            .Where(p => p.Category == "Electronics")
            .OrderByDescending(p => p.Price)
            .Take(3)
            .Select(p => p.Name);

        Console.WriteLine("Top 3 the most expensive products are: ");

        foreach (var product in expensiveProducts)
        {
            Console.WriteLine(product);
        }

    }

}