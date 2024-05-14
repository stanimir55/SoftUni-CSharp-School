string commands;
Queue<string> customerNames = new Queue<string>();

while ((commands = Console.ReadLine()) != "End")
{
    if (commands == "Paid")
    {
        foreach (var name in customerNames)
        {
            Console.WriteLine(name);
        }

        customerNames.Clear();
    }
    else
    {
        customerNames.Enqueue(commands);
    }
}

Console.WriteLine($"{customerNames.Count} people remaining.");