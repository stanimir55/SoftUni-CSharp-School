int[] arr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int fold = arr.Length / 2 / 2;

int[] result = new int[fold * 2];

for (int i = 0; i < fold; i++)
{
    result[i] = arr[i + fold] + arr[fold - 1 - i];
    result[i + fold] = arr[i + 2 * fold] + arr[arr.Length - 1 - i];
}

Console.WriteLine(string.Join(" ", result));