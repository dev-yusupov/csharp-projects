using System;
using System.Linq;
using System.Collections.Generic;

public class OrderItem
{
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

public class Order
{
    public int OrderId { get; set; }
    public List<OrderItem> Items { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>
{
    new Order
    {
        OrderId = 1,
        Items = new List<OrderItem>
        {
            new OrderItem { ProductName = "iPhone", Price = 1399, Quantity = 1 },
            new OrderItem { ProductName = "Headphones", Price = 199, Quantity = 2 }
        }
    },
    new Order
    {
        OrderId = 2,
        Items = new List<OrderItem>
        {
            new OrderItem { ProductName = "iPhone", Price = 1399, Quantity = 2 },
            new OrderItem { ProductName = "Macbook", Price = 1699, Quantity = 1 }
        }
    },
    new Order
    {
        OrderId = 3,
        Items = new List<OrderItem>
        {
            new OrderItem { ProductName = "Macbook", Price = 1699, Quantity = 3 },
            new OrderItem { ProductName = "iPad", Price = 1299, Quantity = 1 }
        }
    },
    new Order
    {
        OrderId = 4,
        Items = new List<OrderItem>
        {
            new OrderItem { ProductName = "Headphones", Price = 199, Quantity = 1 },
            new OrderItem { ProductName = "iPad", Price = 1299, Quantity = 2 }
        }
    },
    new Order
    {
        OrderId = 5,
        Items = new List<OrderItem>
        {
            new OrderItem { ProductName = "Macbook", Price = 1699, Quantity = 1 },
            new OrderItem { ProductName = "Tablet", Price = 600, Quantity = 3 }
        }
    },
    new Order
    {
        OrderId = 6,
        Items = new List<OrderItem>
        {
            new OrderItem { ProductName = "Mac Studio", Price = 2499, Quantity = 1 },
            new OrderItem { ProductName = "iPhone", Price = 1399, Quantity = 2 }
        }
    },
    new Order
    {
        OrderId = 7,
        Items = new List<OrderItem>
        {
            new OrderItem { ProductName = "Mac Studio", Price = 2499, Quantity = 2 },
            new OrderItem { ProductName = "Tablet", Price = 600, Quantity = 2 }
        }
    },
    new Order
    {
        OrderId = 8,
        Items = new List<OrderItem>
        {
            new OrderItem { ProductName = "Smartphone", Price = 800, Quantity = 2 },
            new OrderItem { ProductName = "Mac Studio", Price = 2499, Quantity = 1 }
        }
    },
    new Order
    {
        OrderId = 9,
        Items = new List<OrderItem>
        {
            new OrderItem { ProductName = "Smartphone", Price = 800, Quantity = 3 },
            new OrderItem { ProductName = "Tablet", Price = 600, Quantity = 2 }
        }
    },
    new Order
    {
        OrderId = 10,
        Items = new List<OrderItem>
        {
            new OrderItem { ProductName = "iPhone", Price = 1399, Quantity = 1 },
            new OrderItem { ProductName = "Macbook", Price = 1699, Quantity = 2 }
        }
    },
    new Order
    {
        OrderId = 11,
        Items = new List<OrderItem>
        {
            new OrderItem { ProductName = "Mac Studio", Price = 2499, Quantity = 1 },
            new OrderItem { ProductName = "iPad", Price = 1299, Quantity = 1 }
        }
    },
    new Order
    {
        OrderId = 12,
        Items = new List<OrderItem>
        {
            new OrderItem { ProductName = "Smartphone", Price = 800, Quantity = 1 },
            new OrderItem { ProductName = "Tablet", Price = 600, Quantity = 2 }
        }
    },
    new Order
    {
        OrderId = 13,
        Items = new List<OrderItem>
        {
            new OrderItem { ProductName = "Headphones", Price = 199, Quantity = 2 },
            new OrderItem { ProductName = "Macbook", Price = 1699, Quantity = 1 }
        }
    },
    new Order
    {
        OrderId = 14,
        Items = new List<OrderItem>
        {
            new OrderItem { ProductName = "iPad", Price = 1299, Quantity = 1 },
            new OrderItem { ProductName = "Macbook", Price = 1699, Quantity = 1 }
        }
    },
    new Order
    {
        OrderId = 15,
        Items = new List<OrderItem>
        {
            new OrderItem { ProductName = "Mac Studio", Price = 2499, Quantity = 1 },
            new OrderItem { ProductName = "Smartphone", Price = 800, Quantity = 1 }
        }
    },
    new Order
    {
        OrderId = 16,
        Items = new List<OrderItem>
        {
            new OrderItem { ProductName = "Tablet", Price = 600, Quantity = 2 },
            new OrderItem { ProductName = "iPhone", Price = 1399, Quantity = 1 }
        }
    },
    new Order
    {
        OrderId = 17,
        Items = new List<OrderItem>
        {
            new OrderItem { ProductName = "Headphones", Price = 199, Quantity = 2 },
            new OrderItem { ProductName = "Mac Studio", Price = 2499, Quantity = 1 }
        }
    },
    new Order
    {
        OrderId = 18,
        Items = new List<OrderItem>
        {
            new OrderItem { ProductName = "Macbook", Price = 1699, Quantity = 2 },
            new OrderItem { ProductName = "Smartphone", Price = 800, Quantity = 1 }
        }
    },
    new Order
    {
        OrderId = 19,
        Items = new List<OrderItem>
        {
            new OrderItem { ProductName = "iPhone", Price = 1399, Quantity = 1 },
            new OrderItem { ProductName = "Tablet", Price = 600, Quantity = 3 }
        }
    },
    new Order
    {
        OrderId = 20,
        Items = new List<OrderItem>
        {
            new OrderItem { ProductName = "iPad", Price = 1299, Quantity = 1 },
            new OrderItem { ProductName = "Macbook", Price = 1699, Quantity = 1 }
        }
    },
    new Order
    {
        OrderId = 21,
        Items = new List<OrderItem>
        {
            new OrderItem { ProductName = "Mac Studio", Price = 2499, Quantity = 1 },
            new OrderItem { ProductName = "Headphones", Price = 199, Quantity = 2 }
        }
    },
    new Order
    {
        OrderId = 22,
        Items = new List<OrderItem>
        {
            new OrderItem { ProductName = "Smartphone", Price = 800, Quantity = 3 },
            new OrderItem { ProductName = "iPad", Price = 1299, Quantity = 1 }
        }
    },
    new Order
    {
        OrderId = 23,
        Items = new List<OrderItem>
        {
            new OrderItem { ProductName = "iPhone", Price = 1399, Quantity = 2 },
            new OrderItem { ProductName = "Tablet", Price = 600, Quantity = 1 }
        }
    },
    new Order
    {
        OrderId = 24,
        Items = new List<OrderItem>
        {
            new OrderItem { ProductName = "Macbook", Price = 1699, Quantity = 1 },
            new OrderItem { ProductName = "Mac Studio", Price = 2499, Quantity = 1 }
        }
    }
        };


        var productRevenue = orders
            .SelectMany(order => order.Items)
            .GroupBy(orderItem => orderItem.ProductName)
            .Select(group => new { ProductName = group.Key, TotalRevenue = group.Sum(orderItem => orderItem.Price) });

        foreach (var product in productRevenue)
        {
            Console.WriteLine($"{product.ProductName}: {product.TotalRevenue}");
        }
    }
}



