namespace SpelMedDjur;

public class CagedAnimal : Pet
{
    protected HashSet<Ware> Wares = new();

    public CagedAnimal ()
    {
        Species.Add("caged animal");
    }

}
