namespace SpelMedDjur;

public class Hamster : Rodent
{
    public Hamster()
    {
        Species.Add("hamster");
        AddToAgeMax(3);
        Wares.Add(new Ware() {Name = "hamster", Price = 300});
        Wares.Add(new Ware() {Name = "small cage with decoration", Price = 999});
        Wares.Add(new Ware() {Name = "woodflake bedding", Price = 69});
        Wares.Add(new Ware() {Name = "dry food", Price = 199});
        Wares.Add(new Ware() {Name = "hamster wheel", Price = 199});

        
    }
}
