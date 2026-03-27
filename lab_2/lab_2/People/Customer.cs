namespace lab_2.People;

public abstract class Customer
{
    public string Name { get; set; }

    protected Customer(string name)
    {
        Name = name;
    }
}