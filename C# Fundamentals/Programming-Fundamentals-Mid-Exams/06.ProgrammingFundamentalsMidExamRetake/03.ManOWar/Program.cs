List<int> pirateShip = Console.ReadLine()
    .Split(">")
    .Select(int.Parse)
    .ToList();
List<int> warship = Console.ReadLine()
    .Split(">")
    .Select(int.Parse)
    .ToList();
int maximumHealthCapacityShip = int.Parse(Console.ReadLine());

string commands;
while ((commands = Console.ReadLine()) != "Retire")
{
    string[] arguments = commands.Split();

    switch (arguments[0])
    {
        case "Fire":
            int index = int.Parse(arguments[1]);
            int fireDamage = int.Parse(arguments[2]);

            if (index >= 0 && index < warship.Count)
            {
                warship[index] -= fireDamage;

                if (warship[index] <= 0)
                {
                    Console.WriteLine("You won! The enemy ship has sunken.");
                    return;
                }
            }
            break;
        case "Defend":
            int startIndex = int.Parse(arguments[1]);
            int endIndex = int.Parse(arguments[2]);
            int damage = int.Parse(arguments[3]);

            if (startIndex >= 0 && startIndex < pirateShip.Count &&
                endIndex >= 0 && endIndex < pirateShip.Count)
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    pirateShip[i] -= damage;

                    if (pirateShip[i] <= 0)
                    {
                        Console.WriteLine("You lost! The pirate ship has sunken.");
                        return;
                    }
                }
            }
            break;
        case "Repair":
            int repairIndex = int.Parse(arguments[1]);
            int repairHealth = int.Parse(arguments[2]);

            if (repairIndex >= 0 && repairIndex < pirateShip.Count)
            {
                pirateShip[repairIndex] += repairHealth;
                _ = pirateShip[repairIndex] > maximumHealthCapacityShip ? pirateShip[repairIndex] = maximumHealthCapacityShip : default;
            }
            break;
        case "Status":
            Console.WriteLine($"{pirateShip.Where(x => x < maximumHealthCapacityShip * 0.20).Count()} sections need repair.");
            break;
    }
}

Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
Console.WriteLine($"Warship status: {warship.Sum()}");
