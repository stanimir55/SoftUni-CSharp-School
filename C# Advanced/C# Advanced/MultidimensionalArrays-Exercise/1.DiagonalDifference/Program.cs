int matrixSize = int.Parse(Console.ReadLine());

int[,] matrix = new int[matrixSize, matrixSize];
int primaryDiagonalSum = 0;
int secondaryDiagonalSum = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] numbers = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = numbers[col];
    }
}

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        primaryDiagonalSum += matrix[row,col];
        secondaryDiagonalSum += matrix[col, matrixSize - 1 - row];
        row++;
    }
}
Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));