namespace SpelMedDjur;

public class Rodent : CagedAnimal
{
    public Rodent()
    {
        Species.Add("rodent");
        Wares.Add(new Ware() {Name = "substrate", Price = 249});

    }
}
