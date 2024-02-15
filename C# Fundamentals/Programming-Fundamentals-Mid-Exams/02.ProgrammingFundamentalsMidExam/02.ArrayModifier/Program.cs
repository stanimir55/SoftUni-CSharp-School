List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

string commands;
while ((commands = Console.ReadLine()) != "end")
{
    string[] arguments = commands.Split();

    switch (arguments[0])
    {
        case "swap":
            int firstIndex = int.Parse(arguments[1]);
            int secondIndex = int.Parse(arguments[2]);
            int firstReversed = numbers[firstIndex];
            int secondReversed = numbers[secondIndex];
            numbers.RemoveAt(firstIndex);
            numbers.Insert(firstIndex, secondReversed);
            numbers.RemoveAt(secondIndex);
            numbers.Insert(secondIndex, firstReversed);
            break;
        case "multiply":
            int firstIndexMul = int.Parse(arguments[1]);
            int secondIndexMul = int.Parse(arguments[2]);
            numbers[firstIndexMul] *= numbers[secondIndexMul];
            break;
        case "decrease":
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] -= 1;
            }
            break;
    }
}

Console.WriteLine(string.Join(", ", numbers));
