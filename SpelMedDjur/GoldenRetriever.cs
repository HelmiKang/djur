namespace SpelMedDjur;

public class GoldenRetriever : Dog
{
public GoldenRetriever  ()
    {
    Species.Add("golden retriever");
    AddToPrice(7000);
    Wares.Add(new Ware() {Name = "brush", Price = 99});
    }
}
