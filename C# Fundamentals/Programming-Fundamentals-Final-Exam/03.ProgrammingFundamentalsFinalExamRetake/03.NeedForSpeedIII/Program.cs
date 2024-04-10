int numberOfCars = int.Parse(Console.ReadLine());

var carsDistance = new Dictionary<string, int>();
var carsFuel = new Dictionary<string, int>();

for (int i = 0; i < numberOfCars; i++)
{
    string[] car = Console.ReadLine()
        .Split('|')
        .ToArray();

    string carName = car[0];
    int carMileage = int.Parse(car[1]);
    int fuel = int.Parse(car[2]);

    carsDistance[carName] = carMileage;
    carsFuel[carName] = fuel;
}

string[] command = Console.ReadLine()
    .Split(" : ")
    .ToArray();

while (command[0] != "Stop")
{
    string carName = command[1];

    if (command[0] == "Drive")
    {
        int distance = int.Parse(command[2]);
        int fuel = int.Parse(command[3]);

        if (fuel > carsFuel[carName])
        {
            Console.WriteLine("Not enough fuel to make that ride");
        }
        else
        {
            carsDistance[carName] += distance;
            carsFuel[carName] -= fuel;
            Console.WriteLine($"{carName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
        }

        if (carsDistance[command[1]] >= 100000)
        {
            Console.WriteLine($"Time to sell the {carName}!");
            carsDistance.Remove(carName);
            carsFuel.Remove(carName);
        }
    }
    else if (command[0] == "Refuel")
    {
        int fuel = int.Parse(command[2]);
        int actualNeededFuelAmount = 75 - carsFuel[carName];
        carsFuel[carName] += fuel;

        if (carsFuel[carName] > 75)
        {
            Console.WriteLine($"{carName} refueled with {actualNeededFuelAmount} liters");
            carsFuel[carName] = 75;
        }
        else
        {
            Console.WriteLine($"{carName} refueled with {fuel} liters");
        }
    }
    else if (command[0] == "Revert")
    {
        int revert = int.Parse(command[2]);
        carsDistance[carName] -= revert;

        if (carsDistance[carName] >= 10000)
        {
            Console.WriteLine($"{carName} mileage decreased by {revert} kilometers");
        }
        else
        {
            carsDistance[carName] = 10000;
        }
    }

    command = Console.ReadLine()
        .Split(" : ")
        .ToArray();
}

Console.WriteLine(string.Join($"{Environment.NewLine}", carsDistance
    .Select(x => $"{x.Key} -> Mileage: {x.Value} kms, Fuel in the tank: {carsFuel[x.Key]} lt.")));
