int[] dimensions = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
string snake = Console.ReadLine();

int rows = dimensions[0];
int cols = dimensions[1];
char[,] matrix = new char[rows, cols];
int counter = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        _ = row % 2 == 0 ? matrix[row, col] = snake[counter++] :
            matrix[row, matrix.GetLength(1) - 1 - col] = snake[counter++];

        object value = counter == snake.Length ? counter = 0 : null;
    }
}

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        Console.Write(matrix[row, col]);
    }

    Console.WriteLine();
}
