namespace SpelMedDjur;

public class MaineCoon : Cat
{
    public MaineCoon()
    {
    Species.Add("maine coon");
    AddToAgeMax(7);
    Wares.Add(new Ware() {Name = "brush", Price = 99});
    Wares.Add(new Ware() {Name = "maine coon", Price = 13000});


    }
}   
