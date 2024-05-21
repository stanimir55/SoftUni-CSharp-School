using System.Text;

int linesCount = int.Parse(Console.ReadLine());
int[,] matrix = new int[linesCount, linesCount];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] input = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = input[col];
    }
}

int[] bombs = Console.ReadLine()
    .Split(' ', ',')
    .Select(int.Parse)
    .ToArray();

for (int i = 0; i < bombs.Length - 1; i += 2)
{
    int currentRow = bombs[i];
    int currentCol = bombs[i + 1];
    int value = matrix[currentRow, currentCol];

    if (matrix[currentRow, currentCol] <= 0)
    {
        continue;
    }

    for (int row = currentRow - 1; row <= currentRow + 1; row++)
    {
        for (int col = currentCol - 1; col <= currentCol + 1; col++)
        {
            _ = row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1)
                && matrix[row, col] > 0 ? matrix[row, col] -= value : default;
        }
    }
}

int aliveCells = 0;
int sum = 0;
StringBuilder builder = new StringBuilder();

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (matrix[row, col] > 0)
        {
            sum += matrix[row, col];
            aliveCells++;
        }

        builder.Append(matrix[row, col] + " ");
    }

    builder.AppendLine();
}

Console.WriteLine($"Alive cells: {aliveCells}");
Console.WriteLine($"Sum: {sum}");
Console.WriteLine(builder);
