namespace SpelMedDjur;

public class Hamster : Rodent
{
    public Hamster()
    {
        Species.Add("hamster");
        Wares.Add(new Ware() {Name = "hamster", Price = 300});
        Wares.Add(new Ware() {Name = "small cage with decoration", Price = 999});
        Wares.Add(new Ware() {Name = "woodflake bedding", Price = 69});
    }
}
