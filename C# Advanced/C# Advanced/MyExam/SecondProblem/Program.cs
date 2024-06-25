int size = int.Parse(Console.ReadLine());
char[,] matrix = new char[size, size];

int energy = 15;
int nectar = 0;
int playerRow = -1;
int playerCol = -1;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    char[] input = Console.ReadLine().ToCharArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (input[col] == 'B')
        {
            playerRow = row;
            playerCol = col;

            matrix[row, col] = '-';
            continue;
        }

        matrix[row, col] = input[col];
    }
}

while (true)
{
    string direction = Console.ReadLine();

    if (direction == "up" && IsInside(matrix, playerRow - 1, playerCol))
    {
        playerRow--;
        energy -= 1;
    }
    else if (direction == "down" && IsInside(matrix, playerRow + 1, playerCol))
    {
        playerRow++;
        energy -= 1;
    }
    else if (direction == "right" && IsInside(matrix, playerRow, playerCol + 1))
    {
        playerCol++;
        energy -= 1;
    }
    else if (direction == "left" && IsInside(matrix, playerRow, playerCol - 1))
    {
        playerCol--;
        energy -= 1;
    }
    else
    {
        continue;
    }

    char position = matrix[playerRow, playerCol];

    if (char.IsDigit(position))
    {
        nectar += Convert.ToInt32(new string(position, 1));
        matrix[playerRow, playerCol] = '-';
    }

    if (position == 'H' && nectar >= 30)
    {
        matrix[playerRow, playerCol] = 'B';
        Console.WriteLine($"Great job, Beesy! The hive is full. Energy left: {energy}");
        break;
    }
    else if (position == 'H' && nectar < 30)
    {
        Console.WriteLine("Beesy did not manage to collect enough nectar.");
        break;
    }
    else if (position != 'H' && energy == 0)
    {
        Console.WriteLine("This is the end! Beesy ran out of energy.");
        break;
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

static bool IsInside(char[,] board, int row, int col)
{
    return row >= 0 && row < board.GetLength(0)
        && col >= 0 && col < board.GetLength(1);
}

/*
5
--B--
H-987
-4812
5----
2----
down
right
right
down
left
left
left
down
left
up
up
up
 */