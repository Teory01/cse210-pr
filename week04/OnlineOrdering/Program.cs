using System;

class Program
{
    static void Main(string[] args)
    {
        // First order
        Address address1 = new Address("123 Maple St", "Salt Lake City", "UT", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Keyboard", "KB100", 45.99, 1));
        order1.AddProduct(new Product("Mouse", "MS200", 25.50, 2));

        // Print the packing label, shipping label, and total price for the first order
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

        // Second order
        Address address2 = new Address("456 Elm Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "MN300", 150.00, 1));
        order2.AddProduct(new Product("HDMI Cable", "HD400", 10.00, 3));

        // Print the packing label, shipping label, and total price for the second order
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}
