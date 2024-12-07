using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create address objects
        Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        // Create customer objects
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create product objects
        Product product1 = new Product("Laptop", "P123", 1200.99, 1);
        Product product2 = new Product("Mouse", "P124", 25.50, 2);
        Product product3 = new Product("Keyboard", "P125", 45.75, 1);

        Product product4 = new Product("Phone", "P126", 799.99, 1);
        Product product5 = new Product("Charger", "P127", 19.99, 2);

        // Create order objects and add products
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display order details
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GeneratePackingLabel());
        Console.WriteLine(order1.GenerateShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotal():0.00}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GeneratePackingLabel());
        Console.WriteLine(order2.GenerateShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotal():0.00}\n");
    }
}
