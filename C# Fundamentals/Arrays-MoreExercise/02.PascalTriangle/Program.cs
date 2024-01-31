int linesCount = int.Parse(Console.ReadLine());
int[] row = new int[linesCount];
int[] current = new int[linesCount];
row[0] = 1;

Console.WriteLine(row[0]);

for (int i = 1; i < linesCount; i++)
{
    current[0] = 1;

    Console.Write(row[0] + " ");

    for (int k = 1; k <= i; k++)
    {
        current[k] = row[k - 1] + row[k];
        Console.Write(current[k] + " ");
    }
    for (int m = 0; m < linesCount; m++)
    {
        row[m] = current[m];
    }

    Console.WriteLine();
}