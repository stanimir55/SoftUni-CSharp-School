List<int> train = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

int maxCapacity = int.Parse(Console.ReadLine());

string command;

while ((command = Console.ReadLine()) != "end")
{
    string[] arguments = command.Split();

    if (arguments[0] == "Add")
    {
        int passegers = int.Parse(arguments[1]);

        train.Add(passegers);
    }
    else
    {
        int newPassegers = int.Parse(arguments[0]);

        for (int i = 0; i < train.Count; i++)
        {
            if (train[i] + newPassegers <= maxCapacity)
            {
                train[i] += newPassegers;
                break;
            }
        }
    }
}

Console.WriteLine(string.Join(" ", train));