string key = Console.ReadLine();
string commands;

while ((commands = Console.ReadLine()) != "Generate")
{
    string[] command = commands.Split(">>>").ToArray();

    switch (command[0])
    {
        case "Contains":
            string substring = command[1];
            if (key.Contains(substring))
            {
                Console.WriteLine($"{key} contains {substring}");
            }
            else
            {
                Console.WriteLine("Substring not found!");
            }
            break;
        case "Flip":
            int startIndex = int.Parse(command[2]);
            int endIndex = int.Parse(command[3]);

            if (command[1] == "Upper")
            {
                string result = key.Substring(startIndex, endIndex - startIndex).ToUpper();
                key = key.Remove(startIndex, endIndex - startIndex);
                key = key.Insert(startIndex, result);

                Console.WriteLine(key);
            }
            else if (command[1] == "Lower")
            {
                string result = key.Substring(startIndex, endIndex - startIndex).ToLower();
                key = key.Remove(startIndex, endIndex - startIndex);
                key = key.Insert(startIndex, result);

                Console.WriteLine(key);
            }
            break;
        case "Slice":
            int sliceStartIndex = int.Parse(command[1]);
            int sliceEndIndex = int.Parse(command[2]);

            key = key.Remove(sliceStartIndex, sliceEndIndex - sliceStartIndex);
            Console.WriteLine(key);
            break;
    }
}

Console.WriteLine($"Your activation key is: {key}");
