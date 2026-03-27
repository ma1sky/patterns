using lab_2.People;

namespace lab_2.Order;

using System;

public class TakeawayOrderBuilder : IOrderBuilder
{
    private Order order = new Order();
    private const int MAX_DISHES = 5;

    public TakeawayOrderBuilder()
    {
        order.Type = OrderType.Takeaway;
    }

    public void AssignChef(Chef chef)
    {
        if (chef.IsBusy)
            throw new Exception("Chef is already busy!");

        order.Chef = chef;
        chef.IsBusy = true;
    }

    public void AddCustomer(Customer customer)
    {
        order.Customers.Add(customer);
    }

    public void AddDish(Dish dish)
    {
        if (order.Dishes.Count >= MAX_DISHES)
            throw new Exception("Dish limit reached!");

        order.Dishes.Add(dish);
    }

    public Order Build()
    {
        if (!order.IsReady())
            throw new Exception("Order is not ready!");

        return order;
    }
}