using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("742 Evergreen Terrace", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Daniel Anderson", address1);

        Product product1 = new Product("Donuts", "P001", 1.50, 12);
        Product product2 = new Product("Duff Beer", "P002", 3.00, 6);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine("___ Orden 1 ___");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"{product1.ShowProductInformation()}");
        Console.WriteLine($"{product2.ShowProductInformation()}");
        Console.WriteLine($"Total cost: ${order1.CalculateTotalCost():0.00}");
        Console.WriteLine();

        Address address2 = new Address("Baker Street 221B", "Berlin", "Berlin", "GR");
        Customer customer2 = new Customer("Sebastian MÜller", address2);

        //cliente 2
        Product product3 = new Product("Magnifying Glass", "P010", 15.00, 1);
        Product product4 = new Product("Violin", "P011", 120.00, 1);
        Product product5 = new Product("Pipe", "P012", 25.00, 2);

        // Orden 2
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine("___ Orden 2 ___");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"{product3.ShowProductInformation()}");
        Console.WriteLine($"{product4.ShowProductInformation()}");
        Console.WriteLine($"{product5.ShowProductInformation()}");
        Console.WriteLine($"Total cost: ${order2.CalculateTotalCost():0.00}");
    }
}