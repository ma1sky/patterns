namespace lab_1;

public class InfectDog : Infect
{
    public override int FleaLimit => 100;

    public void ChooseDog(Dog dog)
    {
        ChooseAnimal(dog);
    }
}
