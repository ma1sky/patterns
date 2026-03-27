namespace lab_1;

class Program
{
    static void Main()
    {
        IInfectionFactory catFactory = new CatInfectionFactory();
        var catInfection = (InfectCat)catFactory.CreateInfection();

        catInfection.ChooseCat(Cat.Instance);
        catInfection.AddFlea(new Flea("Ctenocephalides felis #1"));
        catInfection.AddFlea(new Flea("Ctenocephalides felis #2"));

        Console.WriteLine($"Cat infected: {catInfection.IsInfected()}");

        IInfectionFactory dogFactory = new DogInfectionFactory();
        var dogInfection = (InfectDog)dogFactory.CreateInfection();

        dogInfection.ChooseDog(Dog.Instance);
        dogInfection.AddFlea(new Flea("Ctenocephalides canis #1"));

        Console.WriteLine($"Dog infected: {dogInfection.IsInfected()}");
    }
}
