namespace SpelMedDjur;

public class CornSnake : Reptile
{
    public CornSnake()
    {
        Species.Add("corn snake");
        AddToAgeMax(7);
        Wares.Add(new Ware() {Name = "corn snake", Price = 1000});
        Wares.Add(new Ware() {Name = "substrate", Price = 69});
        Wares.Add(new Ware() {Name = "waterbowl", Price = 29});
        Wares.Add(new Ware() {Name = "feeding tongs", Price = 149});
        Wares.Add(new Ware() {Name = "dry food", Price = 199});
        Wares.Add(new Ware() {Name = "frozen mice", Price = 2018});
        Wares.Add(new Ware() {Name = "fogger", Price = 798});
        





    }
}
