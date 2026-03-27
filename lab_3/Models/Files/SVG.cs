namespace lab_3;

public class SVG : File
{
    public SVG() : base()
    {
        Type = FileType.svg;
    }

    public SVG(string name, int size, int level = 0) : base(name, FileType.svg, size, level)
    {
    }
}
