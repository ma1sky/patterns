namespace lab_3;

public abstract class Component
{
    protected string Name;
    protected int Level;

    protected Component()
    {
        Name = "Unnamed Component";
        Level = 0;
    }

    protected Component(string name, int level = 0)
    {
        Name = name;
        Level = level;
    }

    internal void SetLevel(int level)
    {
        Level = level;
    }

    public virtual void Add(Component component) { }
    public virtual void Remove(Component component) { }
    public virtual void Print() { }
}
