using System;

class Program
{
    static void Main(string[] args)
    {
       Order order1 = new Order("Jane Generic", "123 British Way SE", "Calgary", "AB", "T2X 4G2", "Canada");
        order1.AddProduct("Ridiculous Shampoo","1234", 159.99, 3);
        order1.AddProduct("Ludicrous Deodorant","3456", 65.00, 2);
        order1.AddProduct("Exorbitant Perfume","5678", 1200.00, 1);
        order1.AddProduct("Highway Robbery Skincare Lotion","8901", 203.99, 2);
       
        Console.WriteLine("Order One details: ");
        Console.WriteLine(order1.CreatePackingLabel());
        Console.WriteLine("Shipped to: ");         
        Console.WriteLine(order1.CreateShippingLabel());
        Console.WriteLine("");
        Console.WriteLine($"The total cost of this order is : ${order1.CalculateOrderTotal()}.");        
        Console.WriteLine("");

        Order order2 = new Order("John Doe", "456 Noelani Ave", "Pearl City", "HI", "96782", "U.S.A.");
        order2.AddProduct("Sky High Shaving Cream","2345", 65.99, 1);
        order2.AddProduct("Ridiculous Shampoo","1234", 159.99, 2);
        order2.AddProduct("Slightly Less Ludricrous Deodorant","4567", 45.99, 2);

        Console.WriteLine("Order Two details: ");
        Console.WriteLine(order2.CreatePackingLabel());
        Console.WriteLine("Shipped to: ");        
        Console.WriteLine(order2.CreateShippingLabel());
        Console.WriteLine("");
        Console.WriteLine($"The total cost of this order is : ${order2.CalculateOrderTotal()}.");        
        Console.WriteLine("");
        
              
    }
}