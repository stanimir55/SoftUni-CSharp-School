
List<Car> cars = new List<Car>();
List<Truck> trucks = new List<Truck>();
int truckCounter = 0;

string command;
while ((command = Console.ReadLine()) != "end")
{
    string[] arguments = command.Split("/");
    string type = arguments[0];

    if (type == "Car")
    {
        Car car = new Car(type, arguments[1], arguments[2], int.Parse(arguments[3]));
        cars.Add(car);
    }
    else if (type == "Truck")
    {
        truckCounter++;
        Truck truck = new Truck(type, arguments[1], arguments[2], int.Parse(arguments[3]));
        trucks.Add(truck);
    }
}

List<Car> sortedCar = cars.OrderBy(car => car.Brand).ToList();
List<Truck> sortedTruck = trucks.OrderBy(truck => truck.Brand).ToList();

for (int i = 0; i < 1; i++)
{
    Console.WriteLine($"Cars:");
}

foreach (Car car in sortedCar)
{
    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
}

if (truckCounter > 0)
{
    for (int i = 0; i < 1; i++)
    {
        Console.WriteLine($"Trucks:");
    }

}

foreach (Truck truck in sortedTruck)
{
    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
}


class Truck
{
    public Truck(string type, string brand, string model, int weight)
    {
        Type = type;
        Brand = brand;
        Model = model;
        Weight = weight;
    }

    public string Type { get; set; }

    public string Brand { get; set; }

    public string Model { get; set; }

    public int Weight { get; set; }
}

class Car
{
    public Car(string type, string brand, string model, int horsePower)
    {
        Type = type;
        Brand = brand;
        Model = model;
        HorsePower = horsePower;
    }

    public string Type { get; set; }

    public string Brand { get; set; }

    public string Model { get; set; }

    public int HorsePower { get; set; }
}



