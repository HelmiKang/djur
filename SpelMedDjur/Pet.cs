using System.Runtime.CompilerServices;

namespace SpelMedDjur;

public class Pet
{
    //Variables ------------------------------------------------------------------------
    public string Name { get; init; }


    public int Age { get; protected set; }

    protected int AgeMax = 0;

    protected int Price = 0;

    protected bool IsFemale = true;
    private List<string> _pronouns = new();
    protected string Gender = "female";

    protected HashSet<Ware> Wares = new();

    protected List<string> Species {get; set; } = new();
    private List<string> _possibleNames = new() {"Fjant", "Floor", "2% Milk", "Snowflake", "Boomqueefa", "Schartzmugel", "Laqueesh", "Buddy", "Bob",};
    

    // Get or set or add ------------------------------------------------------------------------
    public void AddToPrice(int amount) { Price += amount; }
    public void AddToAgeMax (int amount) { AgeMax += amount; }

    public int GetPrice() { return Price; }

   public void AddToPossibleNames(List<string> newNames) {  


    _possibleNames.AddRange(newNames);
   }


    //Game mechanics ------------------------------------------------------------------------
    public Pet()
    {

      //Decide gender
      IsFemale = Random.Shared.Next(2) == 0;
      if (IsFemale == false)
      {
        AddToPossibleNames(new List<string> {"Herbert", "Stinkboy", "Hågbert", "Göran"});
        Gender = "male";
        _pronouns.Add("he");
        _pronouns.Add("his");
      }
      else
      {
        AddToPossibleNames(new List<string> {"Anna", "Greta", "Britta", "Sweetie"});
        _pronouns.Add("she");
        _pronouns.Add("her");
      }

      // decide name
     int i = Random.Shared.Next(_possibleNames.Count);
     Name=_possibleNames[i];  

    }


    // skriver ut information om en pet
    public void GetInfo()
    {
      Console.WriteLine($"{Name} is a {Species[2]} {Species[1]} , {_pronouns[0]} is a {Gender}.");
    }

    // Skriver att man har adopterat ett djur
    public void Adopt()
    {
      int age = Random.Shared.Next(1, AgeMax);
      Age = age;
      Console.WriteLine($"You have adopted {Name}");
      Console.WriteLine($"{Name} is {Age} years old, {Species[2]}s can live to be {AgeMax} years old.");
    }


    // skriver ut ens shopping list, priser och totala värde
  public void WriteShoppingList()
  {
    Console.WriteLine("List of things you need to buy:");
    foreach(var val in Wares)
        {
            Console.WriteLine($"{val.Name} {val.Price} :-");
            AddToPrice(val.Price);
        }
    Console.WriteLine(" ");
    Console.WriteLine($"Your shopping total: {Price} :-");

  }




}
