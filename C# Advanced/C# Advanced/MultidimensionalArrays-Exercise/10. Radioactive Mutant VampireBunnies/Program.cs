int[] dimensions = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int rows = dimensions[0];
int cols = dimensions[1];
char[,] matrix = new char[rows, cols];
List<int> bunnies = new List<int>();

int playerRow = 0;
int playerCol = 0;
bool playerWon = false;
bool playerDied = false;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    char[] input = Console.ReadLine().ToCharArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = input[col];

        if (matrix[row, col] == 'P')
        {
            playerRow = row;
            playerCol = col;
        }

        if (matrix[row, col] == 'B')
        {
            bunnies.Add(row);
            bunnies.Add(col);
        }
    }
}

string directions = Console.ReadLine();

for (int i = 0; i < directions.Length; i++)
{
    matrix[playerRow, playerCol] = '.';

    if (directions[i] == 'R' && IsInside(matrix, playerRow, playerCol + 1))
    {
        playerCol++;
    }
    else if (directions[i] == 'L' && IsInside(matrix, playerRow, playerCol - 1))
    {
        playerCol--;
    }
    else if (directions[i] == 'U' && IsInside(matrix, playerRow - 1, playerCol))
    {
        playerRow--;
    }
    else if (directions[i] == 'D' && IsInside(matrix, playerRow + 1, playerCol))
    {
        playerRow++;
    }
    else
    {
        playerWon = true;
    }

    if (matrix[playerRow, playerCol] == 'B')
    {
        playerDied = true;
    }
    else if (!playerWon)
    {

        matrix[playerRow, playerCol] = 'P';
    }

    for (int k = 0; k < bunnies.Count - 1; k += 2)
    {
        int bunnyRow = bunnies[k];
        int bunnyCol = bunnies[k + 1];
        int[] positions =
        {
            -1, 0,
            1, 0,
            0, 1,
            0, -1

        };

        for (int m = 0; m < positions.Length - 1; m += 2)
        {
            int nextRow = bunnyRow + positions[m];
            int nextCol = bunnyCol + positions[m + 1];

            if (IsInside(matrix, nextRow, nextCol))
            {
                _ = matrix[nextRow, nextCol] == 'P' ? playerDied = true : default;
                matrix[nextRow, nextCol] = 'B';
            }
        }
    }

    if (playerWon || playerDied)
    {
        break;
    }

    bunnies = new List<int>();

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (matrix[row, col] == 'B')
            {
                bunnies.Add(row);
                bunnies.Add(col);
            }
        }
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

Console.WriteLine($"{(playerWon ? "won" : "dead")}: {playerRow} {playerCol}");

static bool IsInside(char[,] board, int row, int col)
{
    return row >= 0 && row < board.GetLength(0)
        && col >= 0 && col < board.GetLength(1);
}