﻿int[] dimensions = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int rows = dimensions[0];
int cols = dimensions[1];
char[,] matrix = new char[rows, cols];
int counter = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string[] input = Console.ReadLine().Split();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = input[col][0];
    }
}

for (int row = 0; row < matrix.GetLength(0) - 1; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
    {
        _ = matrix[row, col] == matrix[row, col + 1] &&
          matrix[row + 1, col] == matrix[row + 1, col + 1] &&
          matrix[row, col] == matrix[row + 1, col] ? counter++ : default;
    }
}

Console.WriteLine(counter);