namespace lab_1;

public sealed class Dog : Animal
{
    private static readonly Dog instance = new();

    public static Dog Instance => instance;

    private Dog()
    {
    }

    public override string Species => "Dog";
}
