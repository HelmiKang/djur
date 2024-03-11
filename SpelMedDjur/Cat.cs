namespace SpelMedDjur;

public class Cat : Mammal
{
    public Cat()
    {
    AddToPrice(500);
    Wares.Add(new Ware() {Name = "food bowls", Price = 109});
    Wares.Add(new Ware() {Name = "cat toy", Price = 99});
    Wares.Add(new Ware() {Name = "litter box", Price = 219});
    Wares.Add(new Ware() {Name = "cat litter", Price = 149});



    }
}
