int number = int.Parse(Console.ReadLine());
List<Car> cars = new List<Car>();

for (int i = 0; i < number; i++)
{
    string[] arguments = Console.ReadLine()
        .Split()
        .ToArray();

    string model = arguments[0];
    double fuelAmout = double.Parse(arguments[1]);
    double fuelConsumption = double.Parse(arguments[2]);

    Car car = new Car();

    car.Model = model;
    car.FuelAmout = fuelAmout;
    car.FuelConsumption = fuelConsumption;
    
    cars.Add(car);
}

string command;

while ((command = Console.ReadLine()) != "End")
{
    string[] arguments = command.Split();

    string commandDrive = arguments[0];
    string model = arguments[1];
    int amoutOfKm = int.Parse(arguments[2]);

    for (int i = 0; i < cars.Count; i++)
    {
        if (cars[i].Model == model)
        {
            cars[i].Calculate(amoutOfKm);
        }
    }
}

for (int i = 0; i < cars.Count; i++)
{
    Console.WriteLine(cars[i]);
}


class Car
{
    public string Model { get; set; }

    public double FuelAmout { get; set; }

    public double FuelConsumption { get; set; }

    public int TraveledKm { get; set; }

    public void Calculate(int currentDistance)
    {
        double amoutOFuel = FuelConsumption * currentDistance;
        if (FuelAmout >= amoutOFuel)
        {
            FuelAmout -= amoutOFuel;
            TraveledKm += currentDistance;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }

    public override string ToString()
    {
        return $"{Model} {FuelAmout:F2} {TraveledKm}";
    }
}
