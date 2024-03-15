namespace SpelMedDjur;

public class Cat : Mammal
{
    public Cat()
    {
    Species.Add("cat");

    AddToPrice(500);
    Wares.Add(new Ware() {Name = "food bowls", Price = 109});
    Wares.Add(new Ware() {Name = "cat toy", Price = 99});
    Wares.Add(new Ware() {Name = "litter box", Price = 219});
    Wares.Add(new Ware() {Name = "cat litter", Price = 149});

    int i = Random.Shared.Next(2);

    if (i == 1)
    { 
    Pet p = new Cat();
    }

    if (i == 2)
    { 
    Pet p = new Dog();
    } 

    }
}
