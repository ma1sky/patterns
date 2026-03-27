using lab_2.People;

namespace lab_2.Order;

public interface IOrderBuilder
{
    void AssignChef(Chef chef);
    void AddCustomer(Customer customer);
    void AddDish(Dish dish);
    Order Build();
}