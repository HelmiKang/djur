namespace SpelMedDjur;

public class Chihuahua : Dog
{
    public Chihuahua ()
    {
    Species.Add("chihuahua");
    AddToAgeMax(7);
    Wares.Add(new Ware() {Name = "coat", Price = 299});
    }
}
