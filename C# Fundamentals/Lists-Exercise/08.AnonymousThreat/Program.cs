List<string> list = Console.ReadLine()
    .Split()
    .ToList();

string commands = "";

while ((commands = Console.ReadLine()) != "3:1")
{
    string[] arguments = commands.Split(' ');
    int startIndex = int.Parse(arguments[1]);
    int endIndex = int.Parse(arguments[2]);

    if (arguments[0] == "merge")
    {
        if (startIndex < 0)
        {
            startIndex = 0;
        }

        if (endIndex >= list.Count)
        {
            endIndex = list.Count - 1;
        }

        for (int diff = endIndex - startIndex; diff > 0; diff--)
        {
            list[startIndex] += list[startIndex + 1];
            list.RemoveAt(startIndex + 1);
        }
    }
    if (arguments[0] == "divide")
    {
        int partSize = list[startIndex].Length / endIndex;
        int counter = endIndex;
        int off = 1;

        while (counter > 1)
        {
            counter--;
            list.Insert(startIndex + off, new string(list[startIndex].Take(partSize).ToArray()));

            off++;
            list[startIndex] = new string(list[startIndex].Skip(partSize).ToArray());
        }

        list.Insert(startIndex + off, list[startIndex]);
        list.RemoveAt(startIndex);
    }
}

Console.WriteLine(string.Join(" ", list));

