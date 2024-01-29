int linesCount = int.Parse(Console.ReadLine());
int[] numbers = new int[linesCount];

for (int i = 0; i < linesCount; i++)
{
    int number = int.Parse(Console.ReadLine());
    numbers[i] = number;
}

Console.WriteLine(string.Join(" ", numbers.Reverse()));