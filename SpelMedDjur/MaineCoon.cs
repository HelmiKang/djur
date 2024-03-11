namespace SpelMedDjur;

public class MaineCoon : Cat
{
    public MaineCoon()
    {
    AddToPrice(12500);
    AddToAgeMax(7);
    Wares.Add(new Ware() {Name = "brush", Price = 99});

    }
}   
