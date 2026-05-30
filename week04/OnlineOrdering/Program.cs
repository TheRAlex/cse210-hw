using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Online Ordering System");
        Console.WriteLine();


        Console.WriteLine("------------------------------------------");
        Console.WriteLine("ORDER 1");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine();

        
        Address address1 = new Address("456 Oak Lane", "Salt Lake City", "UT", "USA");
        Customer customer1 = new Customer("David Rodriguez", address1);
        
        
        Product p1 = new Product("Wireless Mouse", "WM-100", 25.50m, 2); 
        Product p2 = new Product("Gaming Chair", "RF-900", 79.99m, 1); 
        
        
        Order order1 = new Order(customer1);
        order1.AddProduct(p1);
        order1.AddProduct(p2);

        
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Order Cost: ${order1.GetTotalCost():F2}\n");


        Console.WriteLine("------------------------------------------");
        Console.WriteLine("ORDER 2");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine();

        
        Address address2 = new Address("Lilcoln 20 St W", "Miami", "Florida", "USA");
        Customer customer2 = new Customer("Alex Jones", address2);
        
        
        Product p3 = new Product("USB-C Hub", "UH-C4", 19.99m, 3); 
        Product p4 = new Product("Laptop Stand", "LS-05", 35.00m, 1); 
        Product p5 = new Product("External SSD", "ES-2TB", 120.00m, 1); 
        
        
        Order order2 = new Order(customer2);
        order2.AddProduct(p3);
        order2.AddProduct(p4);
        order2.AddProduct(p5);

        
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        
        Console.WriteLine($"Total Order Cost: ${order2.GetTotalCost():F2}\n");
    }
}