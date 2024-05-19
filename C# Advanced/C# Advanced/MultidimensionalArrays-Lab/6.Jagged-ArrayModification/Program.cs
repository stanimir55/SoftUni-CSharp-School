int linesCount = int.Parse(Console.ReadLine());
int[][] jaggedArr = new int[linesCount][];

for (int row = 0; row < linesCount; row++)
{
    int[] value = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

    jaggedArr[row] = value;
}

string commands;
while ((commands = Console.ReadLine()) != "END")
{
    string[] arguments = commands.Split();

    string action = arguments[0];
    int row = int.Parse(arguments[1]);
    int col = int.Parse(arguments[2]);
    int value = int.Parse(arguments[3]);

    if (row < 0 || row >= linesCount || col < 0 || col >= jaggedArr[row].Length)
    {
        Console.WriteLine("Invalid coordinates");
        continue;
    }

    switch (action)
    {
        case "Add":
            jaggedArr[row][col] += value;
            break;
        case "Subtract":
            jaggedArr[row][col] -= value;
            break;
    }
}

foreach (var row in jaggedArr)
{
    Console.WriteLine(string.Join(" ", row));
}