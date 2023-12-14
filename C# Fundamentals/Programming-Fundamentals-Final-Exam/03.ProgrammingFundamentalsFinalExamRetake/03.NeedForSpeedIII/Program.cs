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

string[] command = Console.ReadLine().Split(" : ").ToArray();

while (command[0] != "Stop")
{
    if (command[0] == "Drive")
    {
        int amortizationMileage = 100000;
        int distance = int.Parse(command[2]);
        int fuel = int.Parse(command[3]);

        if (fuel > carsFuel[command[1]])
        {
            Console.WriteLine("Not enough fuel to make that ride");
        }
        else
        {
            carsDistance[command[1]] += distance;
            carsFuel[command[1]] -= fuel;

            Console.WriteLine($"{command[1]} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
        }

        if (carsDistance[command[1]] >= amortizationMileage)
        {
            Console.WriteLine($"Time to sell the {command[1]}!");

            carsDistance.Remove(command[1]);
            carsFuel.Remove(command[1]);
        }
    }
    else if (command[0] == "Refuel")
    {
        int maxRefillLevel = 75;
        int fuel = int.Parse(command[2]);
        int actualNeededFuelAmount = maxRefillLevel - carsFuel[command[1]];

        carsFuel[command[1]] += fuel;

        if (carsFuel[command[1]] > maxRefillLevel)
        {
            Console.WriteLine($"{command[1]} refueled with {actualNeededFuelAmount} liters");
            carsFuel[command[1]] = maxRefillLevel;
        }
        else
        {
            Console.WriteLine($"{command[1]} refueled with {fuel} liters");
        }
    }
    else if (command[0] == "Revert")
    {
        int minimumMilegeLevel = 10000;
        int revert = int.Parse(command[2]);

        carsDistance[command[1]] -= revert;

        if (carsDistance[command[1]] >= minimumMilegeLevel)
        {
            Console.WriteLine($"{command[1]} mileage decreased by {revert} kilometers");
        }
        else
        {
            carsDistance[command[1]] = minimumMilegeLevel;
        }
    }

    command = Console.ReadLine().Split(" : ").ToArray();
}

Console.WriteLine(string.Join($"{Environment.NewLine}", carsDistance
    .Select(x => $"{x.Key} -> Mileage: {x.Value} kms, Fuel in the tank: {carsFuel[x.Key]} lt.")));
