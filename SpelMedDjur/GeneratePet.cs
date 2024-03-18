namespace SpelMedDjur;

public class GeneratePet
{
    public static Pet PetGenerate()
    {
    int i = Random.Shared.Next(5);

    if (i == 1)
    {
    Pet p = new Moggie();
    return p;
    }

    if (i == 2)
    {
    Pet p = new MaineCoon();
    return p;
    }

    if (i == 3)
    {
    Pet p = new Chihuahua();
    return p;
    }

    if (i == 4)
    {
    Pet p = new GoldenRetriever();
    return p;
    }

    if (i == 5)
    {
    Pet p = new Turtle();
    return p;
    }

    else
    {
    Pet p = new CornSnake();
    return p;
    }
    }
}
