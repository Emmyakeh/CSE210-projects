
class Program
{
    static void Main()
    {
        // Creating products
        Product product1 = new Product("Laptop", "P001", 1200.0, 2);
        Product product2 = new Product("Mouse", "P002", 25.0, 5);
        Product product3 = new Product("Headphones", "P003", 80.0, 1);

        // Creating addresses
        Address customerAddress1 = new Address("123 Main St", "Cityville", "CA", "USA");
        Address customerAddress2 = new Address("456 High St", "Townsville", "ON", "Canada");

        // Creating customers
        Customer customer1 = new Customer("John Doe", customerAddress1);
        Customer customer2 = new Customer("Jane Smith", customerAddress2);

        // Creating orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Displaying results
        Console.WriteLine("Order 1:");
        Console.WriteLine($"Packing Label:\n{order1.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order1.GetShippingLabel()}");
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine($"Packing Label:\n{order2.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order2.GetShippingLabel()}");
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}