using System;

namespace lab_3;

class Program
{
    static void Main()
    {
        var root = new Folder("root");
        var docs = new Folder("docs");
        var assets = new Folder("assets");
        var disk = new Disk("disk");

        var logo = new PNG("logo.png", 120);
        var icon = new SVG("icon.svg", 24);
        var readme = new TXT("readme.txt", 12);

        root.Add(docs);
        root.Add(assets);
        root.Add(disk);

        docs.Add(readme);
        assets.Add(logo);
        assets.Add(icon);

        Console.WriteLine("Composite structure:");
        root.Print();

        Console.WriteLine();
        Console.WriteLine("Remove icon.svg from assets:");
        assets.Remove(icon);
        root.Print();
    }
}
