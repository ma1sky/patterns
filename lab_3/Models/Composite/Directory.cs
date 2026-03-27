using System;
using System.Collections.Generic;

namespace lab_3;

public abstract class Directory : Component
{
    protected readonly List<Component> Components;

    protected Directory() : base()
    {
        Components = new List<Component>();
    }

    protected Directory(string name, int level = 0) : base(name, level)
    {
        Components = new List<Component>();
    }

    public override void Add(Component component)
    {
        if (component == null)
        {
            return;
        }

        component.SetLevel(Level + 1);
        Components.Add(component);
    }

    public override void Remove(Component component)
    {
        if (component == null)
        {
            return;
        }

        Components.Remove(component);
    }

    public override void Print()
    {
        var indent = new string(' ', Level * 2);
        Console.WriteLine($"{indent}+ {Name}");
        foreach (var component in Components)
        {
            component.Print();
        }
    }
}
