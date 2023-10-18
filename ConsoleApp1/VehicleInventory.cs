namespace ConsoleApp1;

public class VehicleInventory : IVehicleInventory
{
    private readonly List<IVehicle> _vehicles = new();
    public void AddVehicle(IVehicle vehicle)
    {
        _vehicles.Add(vehicle);
    }

    public void RemoveVehicle(IVehicle vehicle)
    {
        _vehicles.Remove(vehicle);
    }

    public List<IVehicle> GetVehiclesByModel(string model)
    {
        return _vehicles.Where(v => v.Model.Equals(model)).ToList();
    }

    public int GetVehicleSum()
    {
        return _vehicles.Sum(v => v.Price);
    }

    public List<(int, List<IVehicle>)> GetVehiclesByYear()
    {
        var groups = _vehicles.GroupBy(v => v.Year);
        var result = groups.Select(x => (x.Key, x.ToList()));
        return result.ToList();
    }

    public List<(int, int, List<IVehicle>)> GetVehiclesByYearRage()
    {
        var years = new[] { (2011, 2015), (2016, 2019), (2020, 2024) };

        var result = _vehicles
            .GroupBy(vehicle =>
            years.FirstOrDefault(y => vehicle.Year >= y.Item1 && vehicle.Year <= y.Item2))
            .Select(v => (v.Key.Item1, v.Key.Item2, v.ToList()))
            ;

        return result.ToList();

    }

}