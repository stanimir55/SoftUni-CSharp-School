List<string> rooms = Console.ReadLine()
    .Split("|")
    .ToList();
int health = 100;
double bitcoins = 0;
int counter = 0;
int currHealth = 0;
int tempHealth = 0;

for (int i = 0; i < rooms.Count; i++)
{
    string[] commands = rooms[i].Split().ToArray();

    switch (commands[0])
    {
        case "potion":
            currHealth = health;
            tempHealth = health;
            currHealth += int.Parse(commands[1]);
            counter++;

            if (health + int.Parse(commands[1]) <= 100)
            {
                health += int.Parse(commands[1]);
                Console.WriteLine($"You healed for {int.Parse(commands[1])} hp.");
                Console.WriteLine($"Current health: {currHealth} hp.");
            }
            else if (currHealth > 100)
            {
                int diff = 100 - tempHealth;
                health = 100;
                Console.WriteLine($"You healed for {diff} hp.");
                Console.WriteLine($"Current health: {health} hp.");
            }
            break;
        case "chest":
            bitcoins += int.Parse(commands[1]);
            Console.WriteLine($"You found {int.Parse(commands[1])} bitcoins.");
            counter++;
            break;
        default:
            health -= int.Parse(commands[1]);
            counter++;
            if (health > 0)
            {
                Console.WriteLine($"You slayed {commands[0]}.");
            }
            else
            {
                int bestRoom = 0;

                for (int k = 0; k < rooms.Count; k++)
                {
                    if (rooms.Contains(commands[0] + commands[1]))
                    {
                        bestRoom = i + 1;
                    }
                }
                Console.WriteLine($"You died! Killed by {commands[0]}.");
                Console.WriteLine($"Best room: {counter}");
                return;
            }
            break;
    }
}

Console.WriteLine("You've made it!");
Console.WriteLine($"Bitcoins: {bitcoins}");
Console.WriteLine($"Health: {health}");
