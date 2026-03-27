using System;

namespace lab_3;

public abstract class File : Component
{
    protected FileType Type;
    protected int Size;

    protected File() : base()
    {
        Type = FileType.txt;
        Size = 0;
    }

    protected File(string name, FileType type, int size, int level = 0) : base(name, level)
    {
        Type = type;
        Size = size;
    }

    public override void Print()
    {
        var indent = new string(' ', Level * 2);
        Console.WriteLine($"{indent}- {Name} ({Type}, {Size} bytes)");
    }
}
