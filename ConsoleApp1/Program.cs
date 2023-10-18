

using ConsoleApp1;

var vehicle1 = new Vehicle { Brand = "BENZ", Model = "C200", Year = 2011, Price = 20000 };
var vehicle2 = new Vehicle { Brand = "BMW", Model = "i8", Year = 2012, Price = 30000 };
var vehicle3 = new Vehicle { Brand = "AUDIO", Model = "K20", Year = 2012, Price = 40000 };
var vehicle4 = new Vehicle { Brand = "PEUGEOT", Model = "207", Year = 2017, Price = 15000 };
var vehicle5 = new Vehicle { Brand = "RENAULT", Model = "Sepand", Year = 2022, Price = 17000 };


var inventory = new VehicleInventory();
inventory.AddVehicle(vehicle1);
inventory.AddVehicle(vehicle2);
inventory.AddVehicle(vehicle3);
inventory.AddVehicle(vehicle4);
inventory.AddVehicle(vehicle5);


(int id, string title) t1 = (1, "Hello");
Console.WriteLine(t1);

Console.WriteLine(inventory.GetVehicleSum());
Console.WriteLine(inventory.GetVehiclesByModel("BMW"));
var a = inventory.GetVehiclesByYear();
var b = inventory.GetVehiclesByYearRage();
Console.ReadLine();