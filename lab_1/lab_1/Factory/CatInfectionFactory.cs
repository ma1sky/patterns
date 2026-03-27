namespace lab_1;

public class CatInfectionFactory : IInfectionFactory
{
    public Infect CreateInfection()
    {
        return new InfectCat();
    }
}
