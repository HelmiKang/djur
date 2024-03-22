namespace SpelMedDjur;

public class Bunny : Rodent
{
    public Bunny()
    {
        Species.Add("bunny");
        AddToAgeMax(12);
        Wares.Add(new Ware() {Name = "bunny", Price = 600});
        Wares.Add(new Ware() {Name = "big cage", Price = 999});
        Wares.Add(new Ware() {Name = "X pen", Price = 599});
        Wares.Add(new Ware() {Name = "litter box", Price = 499});
        Wares.Add(new Ware() {Name = "food bowls", Price = 109});
        Wares.Add(new Ware() {Name = "toy", Price = 179});
        Wares.Add(new Ware() {Name = "hidey box", Price = 327});
        Wares.Add(new Ware() {Name = "hay", Price = 99});
        Wares.Add(new Ware() {Name = "dry food", Price = 199});
        Wares.Add(new Ware() {Name = "brush", Price = 99});
        Wares.Add(new Ware() {Name = "nail clipper", Price = 49});
    }
}   
