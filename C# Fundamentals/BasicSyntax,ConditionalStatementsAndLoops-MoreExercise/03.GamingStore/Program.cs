double currentBalance = double.Parse(Console.ReadLine());
string command;
double gamePrice = 0;
double totalSpent = 0;

while ((command = Console.ReadLine()) != "Game Time")
{
    if (command == "OutFall 4")
    {
        gamePrice = 39.99;

        if (currentBalance < gamePrice)
        {
            Console.WriteLine("Too Expensive");
            continue;
        }

        currentBalance -= gamePrice;
        totalSpent += gamePrice;

        Console.WriteLine("Bought OutFall 4");
    }
    else if (command == "CS: OG")
    {
        gamePrice = 15.99;

        if (currentBalance < gamePrice)
        {
            Console.WriteLine("Too Expensive");
            continue;
        }

        currentBalance -= gamePrice;
        totalSpent += gamePrice;

        Console.WriteLine("Bought CS: OG");
    }
    else if (command == "Zplinter Zell")
    {
        gamePrice = 19.99;

        if (currentBalance < gamePrice)
        {
            Console.WriteLine("Too Expensive");
            continue;
        }

        currentBalance -= gamePrice;
        totalSpent += gamePrice;

        Console.WriteLine("Bought Zplinter Zell");
    }
    else if (command == "Honored 2")
    {
        gamePrice = 59.99;

        if (currentBalance < gamePrice)
        {
            Console.WriteLine("Too Expensive");
            continue;
        }

        currentBalance -= gamePrice;
        totalSpent += gamePrice;

        Console.WriteLine("Bought Honored 2");
    }
    else if (command == "RoverWatch")
    {
        gamePrice = 29.99;

        if (currentBalance < gamePrice)
        {
            Console.WriteLine("Too Expensive");
            continue;
        }

        currentBalance -= gamePrice;
        totalSpent += gamePrice;

        Console.WriteLine("Bought RoverWatch");
    }
    else if (command == "RoverWatch Origins Edition")
    {
        gamePrice = 39.99;

        if (currentBalance < gamePrice)
        {
            Console.WriteLine("Too Expensive");
            continue;
        }

        currentBalance -= gamePrice;
        totalSpent += gamePrice;

        Console.WriteLine("Bought RoverWatch Origins Edition");
    }
    else
    {
        Console.WriteLine("Not Found");
    }

    if (currentBalance == 0)
    {
        Console.WriteLine("Out of money!");
        return;
    }
}

Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${currentBalance:F2}");
