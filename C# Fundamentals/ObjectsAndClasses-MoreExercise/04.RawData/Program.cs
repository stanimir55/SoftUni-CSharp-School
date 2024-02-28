int number = int.Parse(Console.ReadLine());
List<Car> cars = new List<Car>();

for (int i = 0; i < number; i++)
{
    string[] areguments = Console.ReadLine()
        .Split()
        .ToArray();

    string model = areguments[0];
    int engineSpeed = int.Parse(areguments[1]);
    int enginePower = int.Parse(areguments[2]);
    int cargoWeight = int.Parse(areguments[3]);
    string cargoType = areguments[4];

    Car car = new Car();

    car.Model = model;
    car.EngineSpeed = engineSpeed;
    car.EnginePower = enginePower;
    car.CargoWeight = cargoWeight;
    car.CargoType = cargoType;

    cars.Add(car);
}

string command = Console.ReadLine();

if (command == "fragile")
{
    List<Car> sorted = cars.Where(x => x.CargoWeight < 1000).ToList();

    for (int i = 0; i < sorted.Count; i++)
    {
        Console.WriteLine(sorted[i]);
    }
}
else if (command == "flamable")
{
    List<Car> sorted = cars.Where(x => x.EnginePower > 250).ToList();

    for (int i = 0; i < sorted.Count; i++)
    {
        Console.WriteLine(sorted[i]);
    }
}


class Car
{
    public string Model { get; set; }

    public int EngineSpeed { get; set; }

    public int EnginePower { get; set; }

    public int CargoWeight { get; set; }

    public string CargoType { get; set; }

    public override string ToString()
    {
        return Model;
    }
}