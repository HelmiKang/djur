using System.Runtime.CompilerServices;

namespace SpelMedDjur;

public class Pet
{
    //Variables ------------------------------------------------------------------------
    protected string Name = "";

    protected int Age;

    protected int AgeMax = 0;

    protected int Price = 0;

    protected bool IsFemale = true;
    private List<string> _pronouns = new();
    protected string Gender = "female";

    public List<string> Species = new();
    private List<string> _possibleNames = new() {"Fjant", "Floor", "2% Milk", "Snowflake", "Boomqueefa", "Schartzmugel", "Laqueesh", "Buddy", "Bob",};
    

    // Get or set or add ------------------------------------------------------------------------
    public void AddToPrice(int amount) { Price += amount; }

    public void SetName(string name) { Name = name; }

    public string GetName() { return Name; }

    public void SetAge(int age) { Age = age; }

    public int GetAge() { return Age; }

    public void AddToAgeMax (int amount) { AgeMax += amount; }

    public int GetPrice() { return Price; }

   public void AddToPossibleNames(List<string> newnames) {  

    _possibleNames.AddRange(newnames);
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

     int i = Random.Shared.Next(_possibleNames.Count);
     SetName(_possibleNames[i]);
     
    }



    public void Adopt()
    {
      Console.WriteLine($"Your pet name is {Name}, {_pronouns[0]} is a {Gender}. {_pronouns[0]} costs {Price}");
      Console.WriteLine($"{Name} is a {Species[0]} {Species[1]} breed {Species[2]}");
    }



    //Actions ------------------------------------------------------------------------
     public virtual void Idle()
    {
        Console.WriteLine("Idle");
    }

      public virtual void Feed()
    {
        Console.WriteLine("Feed");
    }

      public virtual void Sleep()
    {
        Console.WriteLine("Sleep");
    }






}
