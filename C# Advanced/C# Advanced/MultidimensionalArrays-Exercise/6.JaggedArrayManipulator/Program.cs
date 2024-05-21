int linesCount = int.Parse(Console.ReadLine());
int[][] jaggedArr = new int[linesCount][];

for (int i = 0; i < linesCount; i++)
{
    int[] input = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

    jaggedArr[i] = input;
}

for (int row = 0; row < jaggedArr.Length - 1; row++)
{
    if (jaggedArr[row].Length == jaggedArr[row + 1].Length)
    {
        for (int col = 0; col < jaggedArr[row].Length; col++)
        {
            jaggedArr[row][col] *= 2;
            jaggedArr[row + 1][col] *= 2;
        }
    }
    else
    {
        for (int col = 0; col < jaggedArr[row].Length; col++)
        {
            jaggedArr[row][col] /= 2;
        }

        for (int col = 0; col < jaggedArr[row + 1].Length; col++)
        {
            jaggedArr[row + 1][col] /= 2;
        }
    }
}

string commands;
while ((commands = Console.ReadLine()) != "End")
{
    string[] arguments = commands.Split();
    string command = arguments[0];
    int row = int.Parse(arguments[1]);
    int col = int.Parse(arguments[2]);
    int value = int.Parse(arguments[3]);

    if (row >= 0 && row < jaggedArr.Length &&
        col >= 0 && col < jaggedArr[row].Length)
    {
        switch (command)
        {
            case "Add":
                jaggedArr[row][col] += value;
                break;
            case "Subtract":
                jaggedArr[row][col] -= value;
                break;
        }
    }
}

for (int row = 0; row < jaggedArr.Length; row++)
{
    Console.WriteLine(string.Join(" ", jaggedArr[row]));
}