namespace lab_1;

public class InfectCat : Infect
{
    public override int FleaLimit => 50;

    public void ChooseCat(Cat cat)
    {
        ChooseAnimal(cat);
    }
}
