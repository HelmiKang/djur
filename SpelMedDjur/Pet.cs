namespace SpelMedDjur;

public class Pet
{
    private string _name;

    private int _age;

    protected int _ageMax;

    protected int _price;

    public void AddToPrice(int amount) { _price += amount; }

    public void SetName(string name) { _name = name; }

    public void SetAge(int age) { _age = age; }

    public string GetName() { return _name; }

    public int GetAge() { return _age; }

    public int GetPrice() { return _price; }

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
