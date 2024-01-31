int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int fold = numbers.Length / 2 / 2;
int[] result = new int[fold * 2];

for (int i = 0; i < fold; i++)
{
    result[i] = numbers[i + fold] + numbers[fold - 1 - i];
    result[i + fold] = numbers[i + 2 * fold] + numbers[numbers.Length - 1 - i];
}

Console.WriteLine(string.Join(" ",result));