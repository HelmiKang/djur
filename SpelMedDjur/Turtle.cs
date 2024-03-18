namespace SpelMedDjur;

public class Turtle : Reptile
{
    public Turtle()
    {
        Species.Add("turtle");
        Wares.Add(new Ware() {Name = "turtle", Price = 500});
        Wares.Add(new Ware() {Name = "basking lamp", Price = 414});
        Wares.Add(new Ware() {Name = "food", Price = 169});
        Wares.Add(new Ware() {Name = "calcium suppliment", Price = 15});
        Wares.Add(new Ware() {Name = "water filter", Price = 349});



    }
}
