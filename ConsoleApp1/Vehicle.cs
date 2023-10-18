namespace ConsoleApp1;

public class Vehicle : IVehicle
{
    public string? Model { get; set; }
    public string? Brand { get; set; } 
    public int Year { get; set; }
    public int Price { get; set; }

    public override string ToString()
    {
        return $"{Brand} {Model} {Year} ({Price:N0})";
    }
}