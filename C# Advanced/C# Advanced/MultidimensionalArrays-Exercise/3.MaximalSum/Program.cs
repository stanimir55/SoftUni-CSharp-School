﻿int[] dimensions = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int rows = dimensions[0];
int cols = dimensions[1];
int[,] matrix = new int[rows, cols];
int maxSum = int.MinValue;
int targetRow = 0;
int targetCol = 0;

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

for (int row = 0; row < matrix.GetLength(0) - 2; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 2; col++)
    {
        int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
            matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
            matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

        if (currentSum > maxSum)
        {
            maxSum = currentSum;
            targetRow = row;
            targetCol = col;
        }
    }
}

Console.WriteLine($"Sum = {maxSum}");

for (int row = targetRow; row < targetRow + 3; row++)
{
    for (int col = targetCol; col < targetCol + 3; col++)
    {
        Console.Write(matrix[row, col] + " ");
    }

    Console.WriteLine();
}