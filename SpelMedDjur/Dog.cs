namespace SpelMedDjur;

public class Dog : Mammal
{
        public Dog()
    {
        Species.Add("dog");

     AddToPrice(10000);
    Wares.Add(new Ware() {Name = "food bowls", Price = 199});
    Wares.Add(new Ware() {Name = "dog toy", Price = 129});
    Wares.Add(new Ware() {Name = "leash and collar", Price = 399});
    Wares.Add(new Ware() {Name = "poop bags", Price = 19});






    }

}
