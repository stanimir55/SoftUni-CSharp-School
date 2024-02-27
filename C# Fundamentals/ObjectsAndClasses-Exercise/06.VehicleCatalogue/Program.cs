List<Vehicle> catalogue = new List<Vehicle>();

string input;
while ((input = Console.ReadLine()) != "End")
{
    string[] arguments = input.Split();
    catalogue.Add(new Vehicle(arguments[0], arguments[1], arguments[2], int.Parse(arguments[3])));
}

while ((input = Console.ReadLine()) != "Close the Catalogue")
{
    var foundVehicle = catalogue.FirstOrDefault(x => x.Model == input);
    Console.WriteLine(foundVehicle != null ? foundVehicle : default);
}

double averageHp = catalogue
    .Where(x => x.Type == "Car")
    .Select(x => x.HorsePower)
    .DefaultIfEmpty()
    .Average();
Console.WriteLine($"Cars have average horsepower of: {averageHp:F2}.");

averageHp = catalogue
    .Where(x => x.Type == "Truck")
    .Select(x => x.HorsePower)
    .DefaultIfEmpty()
    .Average();
Console.WriteLine($"Trucks have average horsepower of: {averageHp:F2}.");

class Vehicle
{
    public Vehicle(string type, string model, string color, int horsePower)
    {
        if (type == "car")
        {
            Type = "Car";
        }
        else if (type == "truck")
        {
            Type = "Truck";
        }

        Model = model;
        Color = color;
        HorsePower = horsePower;
    }

    public string Type { get; set; }

    public string Model { get; set; }

    public string Color { get; set; }

    public int HorsePower { get; set; }

    public override string ToString()
    {
        return $"Type: {Type}\n" +
            $"Model: {Model}\n" +
            $"Color: {Color}\n" +
            $"Horsepower: {HorsePower}";
    }
}



//string command;
//List<VehicleCatalogue> vehicles = new List<VehicleCatalogue>();

//while ((command = Console.ReadLine()) != "End")
//{
//    string[] arguments = command.Split();

//    string type = arguments[0];
//    string model = arguments[1];
//    string color = arguments[2];
//    double horsePower = double.Parse(arguments[3]);

//    VehicleCatalogue vehicle = new VehicleCatalogue();

//    vehicle.Type = type;
//    vehicle.Model = model;
//    vehicle.Color = color;
//    vehicle.HorsePower = horsePower;

//    vehicles.Add(vehicle);
//}

//for (int i = 0; i < vehicles.Count; i++)
//{
//    if (vehicles[i].Type == "car")
//    {
//        vehicles[i].Type = "Car";
//    }
//    else if (vehicles[i].Type == "truck")
//    {
//        vehicles[i].Type = "Truck";
//    }
//}

//string information;

//while ((information = Console.ReadLine()) != "Close the Catalogue")
//{
//    string[] info = information.Split();

//    string model = info[0];

//    for (int i = 0; i < vehicles.Count; i++)
//    {
//        if (vehicles[i].Model == model)
//        {
//            Console.WriteLine(vehicles[i]);
//        }
//    }
//}

//double carsAverageHorsePower = 0;
//double trucksAverageHorsePower = 0;

//int carsCounter = 0;
//int trucksCounter = 0;

//for (int i = 0; i < vehicles.Count; i++)
//{
//    if (vehicles[i].Type == "Car")
//    {
//        carsAverageHorsePower += vehicles[i].HorsePower;
//        carsCounter++;
//    }
//    else if (vehicles[i].Type == "Truck")
//    {
//        trucksAverageHorsePower += vehicles[i].HorsePower;
//        trucksCounter++;
//    }
//}

//carsAverageHorsePower /= carsCounter;
//trucksAverageHorsePower /= trucksCounter;

//if (trucksAverageHorsePower > 0 && carsAverageHorsePower > 0)
//{
//    Console.WriteLine($"Cars have average horsepower of: {carsAverageHorsePower:f2}.");
//    Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHorsePower:f2}.");
//    return;
//}
//else if (trucksCounter == 0)
//{
//    Console.WriteLine($"Cars have average horsepower of: {carsAverageHorsePower:f2}.");
//    Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
//    return;
//}
//else if (carsCounter == 0)
//{
//    Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
//    Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHorsePower:f2}.");
//    return;
//}

//class VehicleCatalogue
//{
//    public string Type { get; set; }

//    public string Model { get; set; }

//    public string Color { get; set; }

//    public double HorsePower { get; set; }

//    public override string ToString()
//    {
//        return $"Type: {Type}\n" +
//               $"Model: {Model}\n" +
//               $"Color: {Color}\n" +
//               $"Horsepower: {HorsePower}";

//    }
//}
