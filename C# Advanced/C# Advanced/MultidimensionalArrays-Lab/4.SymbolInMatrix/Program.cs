int n = int.Parse(Console.ReadLine());
char[,] matrix = new char[n, n];
bool isBalanced = false;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string characters = Console.ReadLine();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = characters[col];
    }
}

char symbol = char.Parse(Console.ReadLine());

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (matrix[row, col] == symbol)
        {
            isBalanced = true;
            Console.WriteLine($"({row}, {col})");
            return;
        }
    }
}

if (!isBalanced)
{
    Console.WriteLine($"{symbol} does not occur in the matrix");
}