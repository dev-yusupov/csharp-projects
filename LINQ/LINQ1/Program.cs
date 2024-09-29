using System.Linq;


namespace Product
{
    class Product
    {
        public readonly string Name;
        public readonly int Price;
        public readonly int Quantity;

        public Product(string name, int price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 5, 2, 12, 3, 7, 9, 14, 15 };

            var lowNums = from num in numbers
                          where num < 5
                          select num;


            foreach (var num in lowNums)
            {
                Console.WriteLine(num);
            }

            List<Product> products = new List<Product>()
            {
                new Product("Laptop", 10, 0),
                new Product("PC", 50, 2),
                new Product("Microwave", 100, 5),
                new Product("Kettle", 70, 0),
                new Product("Pot", 30, 3),
                new Product("Light", 60, 0),
            };

            var soldProducts = from prod in products
                               where prod.Quantity == 0
                               select prod;

            foreach (var prod in soldProducts)
            {
                Console.WriteLine($"{prod.Name} is sold out!");
            }
        }
    }
}