namespace TopCustomers
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    public class Order
    {
        public DateTime OrderDate { get; set; }
        public List<Product> Products { get; set; }
    }

    public class Customer
    {
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
    }

    public class CustomerTotal
    {
        public string Name { get; set; }
        public decimal Total { get; set; }
        public int OrderCount { get; set; }
    }

    class Program
    {
        static List<Customer> customers = new List<Customer>
        {
            new Customer
            {
                Name = "Alice",
                Orders = new List<Order>
                {
                    new Order
                    {
                        OrderDate = DateTime.Now.AddMonths(-2),
                        Products = new List<Product>
                        {
                            new Product { Name = "Laptop", Price = 1200, Quantity = 1 },
                            new Product { Name = "Mouse", Price = 25, Quantity = 2 }
                        }
                    },
                    new Order
                    {
                        OrderDate = DateTime.Now.AddMonths(-8),
                        Products = new List<Product>
                        {
                            new Product { Name = "Keyboard", Price = 100, Quantity = 1 },
                            new Product { Name = "Monitor", Price = 300, Quantity = 1 }
                        }
                    }
                }
            },
            new Customer
            {
                Name = "Bob",
                Orders = new List<Order>
                {
                    new Order
                    {
                        OrderDate = DateTime.Now.AddMonths(-1),
                        Products = new List<Product>
                        {
                            new Product { Name = "Smartphone", Price = 900, Quantity = 1 },
                            new Product { Name = "Headphones", Price = 150, Quantity = 1 }
                        }
                    },
                    new Order
                    {
                        OrderDate = DateTime.Now.AddMonths(-6),
                        Products = new List<Product>
                        {
                            new Product { Name = "Tablet", Price = 600, Quantity = 1 },
                            new Product { Name = "Charger", Price = 20, Quantity = 2 }
                        }
                    }
                }
            },
            new Customer
            {
                Name = "Charlie",
                Orders = new List<Order>
                {
                    new Order
                    {
                        OrderDate = DateTime.Now.AddMonths(-3),
                        Products = new List<Product>
                        {
                            new Product { Name = "Smartwatch", Price = 300, Quantity = 1 },
                            new Product { Name = "Fitness Tracker", Price = 150, Quantity = 1 }
                        }
                    },
                    new Order
                    {
                        OrderDate = DateTime.Now.AddMonths(-5),
                        Products = new List<Product>
                        {
                            new Product { Name = "Earbuds", Price = 100, Quantity = 2 }
                        }
                    }
                }
            },
            new Customer
            {
                Name = "David",
                Orders = new List<Order>
                {
                    new Order
                    {
                        OrderDate = DateTime.Now.AddMonths(-7),
                        Products = new List<Product>
                        {
                            new Product { Name = "Camera", Price = 800, Quantity = 1 },
                            new Product { Name = "Lens", Price = 500, Quantity = 1 }
                        }
                    }
                }
            },
            new Customer
            {
                Name = "Eve",
                Orders = new List<Order>
                {
                    new Order
                    {
                        OrderDate = DateTime.Now.AddMonths(-1),
                        Products = new List<Product>
                        {
                            new Product { Name = "Laptop", Price = 1500, Quantity = 1 },
                            new Product { Name = "Mouse", Price = 30, Quantity = 1 }
                        }
                    },
                    new Order
                    {
                        OrderDate = DateTime.Now.AddMonths(-4),
                        Products = new List<Product>
                        {
                            new Product { Name = "Tablet", Price = 650, Quantity = 1 }
                        }
                    }
                }
            }
        };

        static void Main(string[] args)
        {
            DateTime sixMonthsAgo = DateTime.Now.AddMonths(-6);
            var topCustomers = customers
                .Select(customer => new CustomerTotal { 
                    Name = customer.Name, 
                    Total = customer.Orders
                        .Where(order => order.OrderDate >= sixMonthsAgo)
                        .Sum(
                            order => order.Products.Sum(
                                product => product.Quantity * product.Price
                                )
                            ),
                    OrderCount = customer.Orders.Count(order => order.OrderDate >= sixMonthsAgo)
                        }
                )
                .OrderByDescending(customer => customer.Total)
                .Take(3)
                .ToList();

            Console.WriteLine("Top 3 Customers in the Last 6 Months:");
            foreach (var customer in topCustomers)
            {
                Console.WriteLine($"{customer.Name}: Total Spend = {customer.Total:F2}, Orders Count = {customer.OrderCount}");
            }
        }

    }
}