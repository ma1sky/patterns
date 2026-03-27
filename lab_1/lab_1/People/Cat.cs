namespace lab_1;

public sealed class Cat : Animal
{
    private static readonly Cat instance = new();

    public static Cat Instance => instance;

    private Cat()
    {
    }

    public override string Species => "Cat";
}