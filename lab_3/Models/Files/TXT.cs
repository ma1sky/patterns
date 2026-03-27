namespace lab_3;

public class TXT : File
{
    public TXT() : base()
    {
        Type = FileType.txt;
    }

    public TXT(string name, int size, int level = 0) : base(name, FileType.txt, size, level)
    {
    }
}
