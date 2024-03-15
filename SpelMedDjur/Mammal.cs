namespace SpelMedDjur;

public class Mammal : Pet
{
   protected HashSet<Ware> Wares = new();

   public Mammal()
   {
   Species.Add("mammal");

   AddToAgeMax(13);
      
   Wares.Add(new Ware() {Name = "Nail clipper", Price = 129});


   }

}
