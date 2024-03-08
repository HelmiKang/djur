using System.Runtime.CompilerServices;

namespace SpelMedDjur;

public class Pet
{
    //Variables ------------------------------------------------------------------------
    protected string _name = "";

    protected int _age;

    protected int _ageMax = 0;

    protected int _price = 0;

    protected bool _isFemale = true;
    private List<string> pronouns = new();
    protected string _gender = "female";


    private List<string> PossibleNames = new() {"Fjant", "Floor", "2% Milk", "Snowflake", "Boomqueefa", "Schartzmugel", "Laqueesh", "Buddy", "Bob",};
    

    // Get or set or add ------------------------------------------------------------------------
    public void AddToPrice(int amount) { _price += amount; }

    public void SetName(string name) { _name = name; }

    public string GetName() { return _name; }

    public void SetAge(int age) { _age = age; }

    public int GetAge() { return _age; }

    public void AddToAgeMax (int amount) { _ageMax += amount; }

    public int GetPrice() { return _price; }

   public void AddToPossibleNames(List<string> newnames) {  

    PossibleNames.AddRange(newnames);
   }


    //Game mechanics ------------------------------------------------------------------------
    public Pet()
    {

      //Decide gender
      _isFemale = Random.Shared.Next(2) == 0;
      if (_isFemale == false)
      {
        AddToPossibleNames(new List<string> {"Herbert", "Stinkboy", "Hågbert", "Göran"});
        _gender = "male";
        pronouns.Add("he");
        pronouns.Add("his");
      }
      else
      {
        AddToPossibleNames(new List<string> {"Anna", "Greta", "Britta", "Sweetie"});
        pronouns.Add("she");
        pronouns.Add("her");
      }

     int i = Random.Shared.Next(PossibleNames.Count);
     SetName(PossibleNames[i]);

     Console.WriteLine($"Your pet name is{_name}  {pronouns} {_gender}");
    }

    public void Adopt()
    {
      
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
