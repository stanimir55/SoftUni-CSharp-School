List<int> numbersList = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

string commands;

while ((commands = Console.ReadLine()) != "End")
{
    string[] arguments = commands.Split();

    if (arguments[0] == "Add")
    {
        int number = int.Parse(arguments[1]);
        numbersList.Add(number);
    }
    else if (arguments[0] == "Insert")
    {
        int number = int.Parse(arguments[1]);
        int index = int.Parse(arguments[2]);

        if (IsNotValidIndex(index, numbersList))
        {
            Console.WriteLine("Invalid index");
        }
        else
        {
            numbersList.Insert(index, number);
        }
    }
    else if (arguments[0] == "Remove")
    {
        int index = int.Parse(arguments[1]);

        if (IsNotValidIndex(index, numbersList))
        {
            Console.WriteLine("Invalid index");
        }
        else
        {
            numbersList.RemoveAt(index);
        }
    }
    else if (arguments[0] == "Shift" && arguments[1] == "left")
    {
        int count = int.Parse(arguments[2]);
        count %= numbersList.Count;

        List<int> shiftedPart = numbersList.GetRange(0, count);
        numbersList.RemoveRange(0, count);
        numbersList.InsertRange(numbersList.Count, shiftedPart);
    }
    else if (arguments[0] == "Shift" && arguments[1] == "right")
    {
        int count = int.Parse(arguments[2]);
        count %= numbersList.Count;

        List<int> shiftedPart = numbersList.GetRange(numbersList.Count - count, count);
        numbersList.RemoveRange(numbersList.Count - count, count);
        numbersList.InsertRange(0, shiftedPart);
    }
}

bool IsNotValidIndex(int index, List<int> numbers)
{
    return index < 0 || index >= numbers.Count;
}

Console.WriteLine(string.Join(" ", numbersList));
