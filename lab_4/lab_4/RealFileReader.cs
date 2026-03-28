namespace lab_4;

class RealFileReader : IFileReader
{
    public override string Read(string path)
    {
        Console.WriteLine($"Reading file from {path}");
        return File.ReadAllText(path);
    }
}