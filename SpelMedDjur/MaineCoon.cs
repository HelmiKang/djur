namespace SpelMedDjur;

public class MaineCoon : Cat
{
    public MaineCoon()
    {
    Species.Add("maine coon");

    AddToPrice(12500);
    AddToAgeMax(7);
    Wares.Add(new Ware() {Name = "brush", Price = 99});

    }
}   
