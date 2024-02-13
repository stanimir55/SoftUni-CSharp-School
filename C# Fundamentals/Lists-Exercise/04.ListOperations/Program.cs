List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

string commands;
while ((commands = Console.ReadLine()) != "End")
{
    string[] arguments = commands.Split();

    switch (arguments[0])
    {
        case "Add":
            int addNumber = int.Parse(arguments[1]);
            numbers.Add(addNumber);
            break;
        case "Insert":
            int insertNumber = int.Parse(arguments[1]);
            int insertIndex = int.Parse(arguments[2]);
            if (insertIndex > numbers.Count || insertIndex < 0)
            {
                Console.WriteLine("Invalid index");
                continue;
            }
            numbers.Insert(insertIndex, insertNumber);
            break;
        case "Remove":
            int index = int.Parse(arguments[1]);
            if (index > numbers.Count || index < 0)
            {
                Console.WriteLine("Invalid index");
                continue;
            }
            numbers.RemoveAt(index);
            break;
        case "Shift": // left // right

            if (arguments[1] == "left")
            {
                int count = int.Parse(arguments[2]);
                count %= numbers.Count;

                List<int> shiftedPart = numbers.GetRange(0, count);
                numbers.RemoveRange(0, count);
                numbers.InsertRange(numbers.Count, shiftedPart);
            }
            else
            {
                int count = int.Parse(arguments[2]);
                count %= numbers.Count;

                List<int> shiftedPart = numbers.GetRange(numbers.Count - count, count);
                numbers.RemoveRange(numbers.Count - count, count);
                numbers.InsertRange(0, shiftedPart);
            }
            break;
    }
}

Console.WriteLine(string.Join(" ", numbers));
