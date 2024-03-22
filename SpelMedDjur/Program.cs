using SpelMedDjur;

bool rightInput = true;

Pet a = GeneratePet.PetGenerate();
Pet b = GeneratePet.PetGenerate();
Pet c = GeneratePet.PetGenerate();

Console.WriteLine("These pets are up for adoption:");
a.GetInfo();
b.GetInfo();
c.GetInfo();

while (rightInput == true)
{   
    
    Console.WriteLine(" ");
    Console.WriteLine("Enter the number of the pet you want to adopt:");
    try {
    int n = int.Parse(Console.ReadLine());
    if (n == 1)
    {   
        a.Adopt();
        Console.WriteLine(" ");
        a.WriteShoppingList();
        break;
    }
    if (n == 2)
    {
        b.Adopt();
        Console.WriteLine(" ");
        b.WriteShoppingList();
        break;
    }
    if (n == 3)
    {
        c.Adopt();
        Console.WriteLine(" ");
        c.WriteShoppingList();

        break;
    }
    else
    {
        Console.WriteLine("Invalid input.");
    }
    }
    // om fel input så får man testa igen
    catch
    {
        Console.WriteLine("Invalid input.");
    }
}






Console.ReadLine();