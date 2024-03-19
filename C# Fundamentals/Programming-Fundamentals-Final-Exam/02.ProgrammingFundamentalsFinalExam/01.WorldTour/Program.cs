string input = Console.ReadLine();

string commands;
while ((commands = Console.ReadLine()) != "Travel")
{
    string[] arguments = commands.Split(":");

    switch (arguments[0])
    {
        case "Add Stop":
            if (int.Parse(arguments[1]) >= 0 && int.Parse(arguments[1]) < input.Length)
                input = input.Insert(int.Parse(arguments[1]), arguments[2]);

            Console.WriteLine(input);
            break;
        case "Remove Stop":
            if (int.Parse(arguments[1]) >= 0 && int.Parse(arguments[1]) < input.Length &&
                int.Parse(arguments[2]) >= 0 && int.Parse(arguments[2]) < input.Length)
                input = input.Remove(int.Parse(arguments[1]), int.Parse(arguments[2]) - int.Parse(arguments[1]) + 1);

            Console.WriteLine(input);
            break;
        case "Switch":
            if (input.Contains(arguments[1]))
                input = input.Replace(arguments[1], arguments[2]);

            Console.WriteLine(input);
            break;
    }
}

Console.WriteLine($"Ready for world tour! Planned stops: {input}");
