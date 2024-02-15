List<string> chest = Console.ReadLine()
    .Split("|")
    .ToList();

string commands;
while ((commands = Console.ReadLine()) != "Yohoho!")
{
    string[] arguments = commands.Split();

    switch (arguments[0])
    {
        case "Loot":
            for (int i = 1; i < arguments.Length; i++)
            {
                if (!chest.Contains(arguments[i]))
                {
                    chest.Insert(0, arguments[i]);
                }
            }
            break;
        case "Drop":
            if (int.Parse(arguments[1]) < 0 || int.Parse(arguments[1]) >= chest.Count)
            {
                continue;
            }
            string currentLoot = chest[int.Parse(arguments[1])];
            chest.RemoveAt(int.Parse(arguments[1]));
            chest.Add(currentLoot);
            break;
        case "Steal":
            List<string> stolenItems = new List<string>();
            if (int.Parse(arguments[1]) < 0)
            {
                continue;
            }

            for (int i = 0; i < int.Parse(arguments[1]); i++)
            {
                if (chest.Count == 0)
                {
                    break;
                }
                stolenItems.Add(chest[chest.Count - 1]);
                chest.RemoveAt(chest.Count - 1);
            }

            stolenItems.Reverse();
            Console.WriteLine(string.Join(", ", stolenItems));
            break;
    }
}

if (chest.Count != 0)
{
    int itemsLenght = 0;

    for (int i = 0; i < chest.Count; i++)
    {
        itemsLenght += chest[i].Length;
    }

    Console.WriteLine($"Average treasure gain: {(double)itemsLenght / chest.Count:F2} pirate credits.");
}
else
{
    Console.WriteLine("Failed treasure hunt.");
}
