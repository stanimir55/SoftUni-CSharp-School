int[] dimensions = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int rows = dimensions[0];
int cols = dimensions[1];
string[,] matrix = new string[rows, cols];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string[] input = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = input[col];
    }
}

string commands;
while ((commands = Console.ReadLine()) != "END")
{
    string[] arguments = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string command = arguments[0];

    if (command != "swap" || arguments.Length != 5)
    {
        Console.WriteLine("Invalid input!");
        continue;
    }

    int firstRow = int.Parse(arguments[1]);
    int firstCol = int.Parse(arguments[2]);
    int secondRow = int.Parse(arguments[3]);
    int secondCol = int.Parse(arguments[4]);

    if (!(firstRow >= 0 && firstRow < matrix.GetLength(0)) ||
        !(firstCol >= 0 && firstCol < matrix.GetLength(1)) ||
        !(secondRow >= 0 && secondRow < matrix.GetLength(0)) ||
        !(secondCol >= 0 && secondCol < matrix.GetLength(1)))
    {
        Console.WriteLine("Invalid input!");
        continue;
    }

    string value = matrix[firstRow, firstCol];
    matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
    matrix[secondRow, secondCol] = value;

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col] + " ");
        }

        Console.WriteLine();
    }
}

