namespace SpelMedDjur;

public class Reptile : CagedAnimal
{
    public Reptile()
    {
        Species.Add("reptile");

        Wares.Add(new Ware() {Name = "medium terrarium", Price = 3089});


    }
}
