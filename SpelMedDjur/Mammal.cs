namespace SpelMedDjur;

public class Mammal : Pet
{
   protected List<Ware> Wares = new();

   public Mammal()
   {
   AddToAgeMax(13);
      
   Wares.Add(new Ware() {Name = "Nail clipper", Price = 129});


   }

}
