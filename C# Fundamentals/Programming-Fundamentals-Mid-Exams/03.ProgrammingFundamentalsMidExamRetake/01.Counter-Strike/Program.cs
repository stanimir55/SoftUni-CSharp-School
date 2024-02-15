double energy = int.Parse(Console.ReadLine());
string command;
int counter = 0;

while ((command = Console.ReadLine()) != "End of battle")
{
    string[] arguments = command.Split();
    double distance = double.Parse(arguments[0]);

    if (energy < distance)
    {
        Console.WriteLine($"Not enough energy! Game ends with {counter} won battles and {energy} energy");
        energy -= distance;

        return;
    }

    energy -= distance;
    counter++;

    if (counter % 3 == 0)
    {
        energy += counter;
    }
}

Console.WriteLine($"Won battles: {counter}. Energy left: {energy}");