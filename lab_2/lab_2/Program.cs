using System;
using lab_2.Order;
using lab_2.People;

class Program
{
    static void Main()
    {
        Chef chef = new Chef("Gordon");

        IOrderBuilder builder = new RestaurantOrderBuilder();

        builder.AssignChef(chef);
        builder.AddCustomer(new AdultCustomer("Alex"));
        builder.AddCustomer(new ChildCustomer("Tom"));

        builder.AddDish(new Dish("Pizza"));
        builder.AddDish(new Dish("Pasta"));

        Order order = builder.Build();

        order.PrintInfo();
    }
}