int fieldSize = int.Parse(Console.ReadLine());
string[] commands = Console.ReadLine().Split();

char[,] matrix = new char[fieldSize, fieldSize];
int totalCoals = 0;
int coalsCount = 0;
int minerRow = 0;
int minerCol = 0;
bool isGameOver = false;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string[] input = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = input[col][0];

        _ = matrix[row, col] == 'c' ? totalCoals++ : default;

        if (matrix[row, col] == 's')
        {
            minerRow = row;
            minerCol = col;
        }
    }
}

for (int i = 0; i < commands.Length; i++)
{
    _ = commands[i] == "left" && IsInside(matrix, minerRow, minerCol - 1) ? minerCol-- : default;
    _ = commands[i] == "right" && IsInside(matrix, minerRow, minerCol + 1) ? minerCol++ : default;
    _ = commands[i] == "up" && IsInside(matrix, minerRow - 1, minerCol) ? minerRow-- : default;
    _ = commands[i] == "down" && IsInside(matrix, minerRow + 1, minerCol) ? minerRow++ : default;

    if (matrix[minerRow, minerCol] == 'e' || totalCoals == coalsCount)
    {
        isGameOver = true;
        break;
    }
    else if (matrix[minerRow, minerCol] == 'c')
    {
        matrix[minerRow, minerCol] = '*';
        coalsCount++;
    }
}

Console.WriteLine(totalCoals == coalsCount ? $"You collected all coals! ({minerRow}, {minerCol})" : null);
Console.WriteLine(isGameOver ? $"Game over! ({minerRow}, {minerCol})" : null);
Console.WriteLine(totalCoals != coalsCount && isGameOver == false ?
    $"{totalCoals - coalsCount} coals left. ({minerRow}, {minerCol})" : null);

bool IsInside(char[,] matrix, int row, int col)
{
    return row >= 0 && row < matrix.GetLength(0) &&
          col >= 0 && col < matrix.GetLength(1);
}