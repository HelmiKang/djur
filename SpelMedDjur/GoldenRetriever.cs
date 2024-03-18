namespace SpelMedDjur;

public class GoldenRetriever : Dog
{
public GoldenRetriever  ()
    {
    Species.Add("golden retriever");
    Wares.Add(new Ware() {Name = "brush", Price = 99});
    Wares.Add(new Ware() {Name = "golden retriever", Price = 17000});

    }
}
