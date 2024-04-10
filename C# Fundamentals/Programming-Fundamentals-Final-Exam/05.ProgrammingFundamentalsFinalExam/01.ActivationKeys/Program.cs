string key = Console.ReadLine();

string command;
while ((command = Console.ReadLine()) != "Generate")
{
    string[] arguments = command.Split(">>>").ToArray();

    switch (arguments[0])
    {
        case "Contains":
            string substring = arguments[1];
            Console.WriteLine(key.Contains(substring) ? $"{key} contains {substring}" : "Substring not found!");
            break;
        case "Flip":
            int startIndex = int.Parse(arguments[2]);
            int endIndex = int.Parse(arguments[3]);

            if (arguments[1] == "Upper")
            {
                string result = key.Substring(startIndex, endIndex - startIndex).ToUpper();
                key = key.Remove(startIndex, endIndex - startIndex).Insert(startIndex, result);
                Console.WriteLine(key);
            }
            else if (arguments[1] == "Lower")
            {
                string result = key.Substring(startIndex, endIndex - startIndex).ToLower();
                key = key.Remove(startIndex, endIndex - startIndex).Insert(startIndex, result);
                Console.WriteLine(key);
            }
            break;
        case "Slice":
            int sliceStartIndex = int.Parse(arguments[1]);
            int sliceEndIndex = int.Parse(arguments[2]);

            key = key.Remove(sliceStartIndex, sliceEndIndex - sliceStartIndex);
            Console.WriteLine(key);
            break;
    }
}

Console.WriteLine($"Your activation key is: {key}");
