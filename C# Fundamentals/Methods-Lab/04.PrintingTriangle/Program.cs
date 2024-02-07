int number = int.Parse(Console.ReadLine());

static void PrintRow(int row)
{
    for (int col = 1; col <= row; col++)
    {
        Console.Write(col + " ");
    }

    Console.WriteLine();
}

for (int row = 1; row <= number; row++)
{
    PrintRow(row);
}

for (int row = number - 1; row >= 1; row--)
{
    PrintRow(row);
}
