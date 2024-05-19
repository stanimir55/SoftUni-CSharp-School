List<int> dimensions = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToList();

int[,] matrix = new int[dimensions[0], dimensions[1]];
int sum = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] values = Console.ReadLine()
        .Split(", ")
        .Select(int.Parse)
        .ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row,col] = values[col];
        sum += values[col];
    }
}

Console.WriteLine(dimensions[0]);
Console.WriteLine(dimensions[1]);
Console.WriteLine(sum);

/*
3, 6
7, 1, 3, 3, 2, 1
1, 3, 9, 8, 5, 6
4, 6, 7, 9, 1, 0
 */