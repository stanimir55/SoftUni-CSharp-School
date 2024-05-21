int rows = int.Parse(Console.ReadLine());
char[,] matrix = new char[rows, rows];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    char[] input = Console.ReadLine().ToCharArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = input[col];
    }
}

int removedKnight = 0;

while (true)
{
    int maxAttacks = 0;
    int knightRow = 0;
    int knightCol = 0;

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            int attacksCount = 0;

            if (matrix[row, col] != 'K')
            {
                continue;
            }

            List<int> positions = new List<int>()
             {
                            -2, -1,
                            -2, 1,
                            2, -1,
                            2, 1,
                            -1, 2,
                            1, 2,
                            -1, -2,
                            1, -2
                        };

            for (int i = 0; i < positions.Count; i += 2)
            {
                int nextRow = row + positions[i];
                int nextCol = col + positions[i + 1];

                _ = IsInside(matrix, nextRow, nextCol) && matrix[nextRow, nextCol] == 'K'
                    ? attacksCount++ : default;
            }

            if (attacksCount > maxAttacks)
            {
                maxAttacks = attacksCount;
                knightRow = row;
                knightCol = col;
            }
        }
    }

    if (maxAttacks > 0)
    {
        matrix[knightRow, knightCol] = '0';
        removedKnight++;
    }
    else
    {
        break;
    }
}

Console.WriteLine(removedKnight);

bool IsInside(char[,] matrix, int row, int col)
{
    return row >= 0 && row < matrix.GetLength(0) &&
           col >= 0 && col < matrix.GetLength(1);
}