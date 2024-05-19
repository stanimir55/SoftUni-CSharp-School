﻿List<int> dimensions = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToList();

int[,] matrix = new int[dimensions[0], dimensions[1]];
int maxSum = int.MinValue;
int maxSumRow = 0;
int maxSumCol = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] values = Console.ReadLine()
        .Split(", ")
        .Select(int.Parse)
        .ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = values[col];
    }
}

for (int row = 0; row < matrix.GetLength(0) - 1; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
    {
        int currentSum = matrix[row, col] + matrix[row, col + 1] +
            matrix[row + 1, col] + matrix[row + 1, col + 1];

        if (currentSum > maxSum)
        {
            maxSum = currentSum;
            maxSumRow = row;
            maxSumCol = col;
        }
    }
}

Console.WriteLine($"{matrix[maxSumRow, maxSumCol]} {matrix[maxSumRow, maxSumCol + 1]}");
Console.WriteLine($"{matrix[maxSumRow + 1, maxSumCol]} {matrix[maxSumRow + 1, maxSumCol + 1]}");
Console.WriteLine(maxSum);
