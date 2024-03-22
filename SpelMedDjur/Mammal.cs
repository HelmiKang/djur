namespace SpelMedDjur;

public class Mammal : Pet
{
   public Mammal()
   {
   Species.Add("mammal");

   AddToAgeMax(13);
      
   Wares.Add(new Ware() {Name = "Nail clipper", Price = 129});


   }

}
