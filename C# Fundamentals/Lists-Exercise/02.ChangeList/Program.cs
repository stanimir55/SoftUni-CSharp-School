using System;

List<int> list = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

string commands;

while ((commands = Console.ReadLine()) != "end")
{
    string[] arguments = commands.Split();

    if (arguments[0] == "Delete")
    {
        int element = int.Parse(arguments[1]);

        for (int i = 0; i < list.Count; i++)
        {
            list.Remove(element);
        }
    }
    else if (arguments[0] == "Insert")
    {
        int element = int.Parse(arguments[1]);
        int position = int.Parse(arguments[2]);

        list.Insert(position, element);
    }
}

Console.WriteLine(string.Join(" ", list));
