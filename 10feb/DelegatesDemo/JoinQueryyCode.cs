namespace DelegatesDemo;
using System;
using System.Collections.Generic;
using System.Linq;



public class Customer
{
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
}

public class Order
{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public string ProductName { get; set; }
}

public class JoinQuery
{
    public static void Run()
    {

        List<Customer> customers = new List<Customer>
        {
            new Customer { CustomerId = 12, CustomerName = "Alice" },
            new Customer { CustomerId = 13, CustomerName = "Bob" }
        };

        List<Order> orders = new List<Order>
        {
            new Order { OrderId = 25, CustomerId = 12, ProductName = "Chair" },
            new Order { OrderId = 26, CustomerId = 15, ProductName = "Table" }
        };

        var result = customers.Join(
            orders,
            c => c.CustomerId,      // key from Customer
            o => o.CustomerId,      // key from Order
            (c, o) => new           // result selector
            {
                c.CustomerName,
                o.ProductName
            }
        );
          Console.WriteLine("JoinDemo is running");
        foreach (var item in result)
        {
            Console.WriteLine($"{item.CustomerName} bought {item.ProductName}");
             
        }
    }
}


