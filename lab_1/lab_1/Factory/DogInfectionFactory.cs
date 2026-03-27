namespace lab_1;

public class DogInfectionFactory : IInfectionFactory
{
    public Infect CreateInfection()
    {
        return new InfectDog();
    }
}
