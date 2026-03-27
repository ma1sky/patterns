namespace lab_1;

public abstract class Infect
{
    private Animal? animal;
    private readonly List<Flea> fleas = new();

    public abstract int FleaLimit { get; }

    protected void ChooseAnimal(Animal selectedAnimal)
    {
        if (animal is not null)
        {
            throw new InvalidOperationException("Animal is already selected.");
        }

        animal = selectedAnimal;
    }

    public void AddFlea(Flea flea)
    {
        if (fleas.Count >= FleaLimit)
        {
            throw new InvalidOperationException("Flea limit exceeded.");
        }

        fleas.Add(flea);
    }

    public bool IsInfected()
    {
        return animal is not null && fleas.Count > 0;
    }
}
