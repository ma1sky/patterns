namespace lab_3;

public class PNG : File
{
    public PNG() : base()
    {
        Type = FileType.png;
    }

    public PNG(string name, int size, int level = 0) : base(name, FileType.png, size, level)
    {
    }
}
