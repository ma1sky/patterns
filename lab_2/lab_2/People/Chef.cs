namespace lab_2.People;

public class Chef
{
    public string Name { get; set; }
    public bool IsBusy { get; set; }

    public Chef(string name)
    {
        Name = name;
        IsBusy = false;
    }
}