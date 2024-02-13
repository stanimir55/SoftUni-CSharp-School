List<int> wagons = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
int wagonMaxCapacity = int.Parse(Console.ReadLine());

string commands;
while ((commands = Console.ReadLine()) != "end")
{
    string[] arguments = commands.Split();

    if (arguments[0] == "Add")
    {
        int passengers = int.Parse(arguments[1]);
        wagons.Add(passengers);
    }
    else
    {
        int newPassegers = int.Parse(arguments[0]);
        for (int i = 0; i < wagons.Count; i++)
        {
            if (newPassegers + wagons[i] <= wagonMaxCapacity)
            {
                wagons[i] += newPassegers;
                break;
            }
        }
    }
}

Console.WriteLine(string.Join(" ", wagons));
