
using System;

class Program
{
    static void Main(string[] args)
    {
        // FIRST ORDER - Customer in the USA
        Address address1 = new Address(
            "123 Main St", "Miami", "Florida", "USA"
        );

        Customer customer1 = new Customer("Carlos", address1);

        Product product1 = new Product("Keyboard", "KB001", 25.0, 2);
        Product product2 = new Product("Mouse", "MS001", 15.0, 3);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // SECOND ORDER - Customer outside the USA
        Address address2 = new Address(
            "456 Los Olivos", "Quito", "Pichincha", "Ecuador"
        );

        Customer customer2 = new Customer("Ana", address2);

        Product product3 = new Product("Monitor", "MN001", 200.0, 1);
        Product product4 = new Product("Headphones", "HP001", 40.0, 2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Store the orders in a list
        List<Order> orders = new List<Order>();
        orders.Add(order1);
        orders.Add(order2);

        // Display each order
        foreach (Order order in orders)
        {
            Console.WriteLine("PACKING LABEL:");
            Console.WriteLine(order.GetPackingLabel());

            Console.WriteLine("SHIPPING LABEL:");
            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine($"TOTAL: ${order.GetTotalPrice():F2}");
            Console.WriteLine("----------------------------");
        }
    }
}
