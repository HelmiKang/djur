namespace SpelMedDjur;

public class Reptile : CagedAnimal
{
    public Reptile()
    {
        Species.Add("reptile");

        Wares.Add(new Ware() {Name = "medium terrarium", Price = 2018});
        Wares.Add(new Ware() {Name = "Hygrometer", Price = 149});
        Wares.Add(new Ware() {Name = "thermometer", Price = 69});
        Wares.Add(new Ware() {Name = "heat mat", Price = 249});
        Wares.Add(new Ware() {Name = "decoration", Price = 689});

    }
}
