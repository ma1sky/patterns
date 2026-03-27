using lab_2.People;

namespace lab_2.Order;

using System;
using System.Collections.Generic;

public class Order
{
    public Chef Chef { get; set; }
    public OrderType Type { get; set; }

    public List<Customer> Customers { get; set; } = new List<Customer>();
    public List<Dish> Dishes { get; set; } = new List<Dish>();

    public bool IsReady()
    {
        return Chef != null && Customers.Count > 0 && Dishes.Count > 0;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Order type: {Type}");
        Console.WriteLine($"Chef: {Chef?.Name}");

        Console.WriteLine("Customers:");
        foreach (var c in Customers)
            Console.WriteLine($" - {c.Name}");

        Console.WriteLine("Dishes:");
        foreach (var d in Dishes)
            Console.WriteLine($" - {d.Name}");
    }
}