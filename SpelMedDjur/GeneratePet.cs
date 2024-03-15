namespace SpelMedDjur;

public class GeneratePet
{
    public static Pet PetGenerate()
    {
    int i = Random.Shared.Next(2);

    if (i == 1)
    {
    Pet p = new Moggie();
    return p;
    }

    else
    {
    Pet p = new MaineCoon();
    return p;
    }

    
    }
}
