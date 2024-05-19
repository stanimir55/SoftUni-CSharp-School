long linesCount = long.Parse(Console.ReadLine());

long[][] pascalTriangle = new long[linesCount][];
pascalTriangle[0] = new long[1] { 1 };

for (int row = 1; row < linesCount; row++)
{
    pascalTriangle[row] = new long[row + 1];

    for (int col = 0; col < pascalTriangle[row].Length; col++)
    {
        long sum = 0;

        if (col > 0)
        {
            sum += pascalTriangle[row - 1][col - 1];
        }

        if (col < pascalTriangle[row - 1].Length)
        {
            sum += pascalTriangle[row - 1][col];
        }

        pascalTriangle[row][col] = sum;
    }
}

foreach (var row in pascalTriangle)
{
    Console.WriteLine(string.Join(" ", row));
}
