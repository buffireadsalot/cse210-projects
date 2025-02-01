using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create Customers
        Customer customer1 = new Customer("Alice Johnson", new Address("123 Main St", "New York", "NY", "USA"));
        Customer customer2 = new Customer("Bob Smith", new Address("45 Maple Ave", "Toronto", "ON", "Canada"));

        // Create Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("P101", "Laptop", 899.99m, 1));
        order1.AddProduct(new Product("P102", "Wireless Mouse", 25.99m, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("P201", "Smartphone", 699.99m, 1));
        order2.AddProduct(new Product("P202", "Phone Case", 19.99m, 3));
        order2.AddProduct(new Product("P203", "Screen Protector", 12.99m, 2));

        // Display Order Details
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("===================================");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("-----------------------------------");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine("-----------------------------------");
        Console.WriteLine($"Total Order Cost: ${order.GetTotalCost():0.00}");
        Console.WriteLine("===================================\n");
    }
}