namespace ConsoleApp1;

public interface IVehicle
{
    public string? Model { get; set; }
    public string Brand { get; set; }
    public int Year { get; set; }
    public int Price { get; set; }
}