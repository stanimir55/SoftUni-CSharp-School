List<int> numbers = Console.ReadLine()
    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

int[] lis;
int[] lenght = new int[numbers.Count];
int[] prev = new int[numbers.Count];
int maxLenght = 0;
int lastIndex = -1;

for (int i = 0; i < numbers.Count; i++)
{
    lenght[i] = 1;
    prev[i] = -1;

    for (int k = 0; k < i; k++)
    {
        if (numbers[k] < numbers[i] && lenght[k] >= lenght[i])
        {
            lenght[i] = lenght[k] + 1;
            prev[i] = k;
        }
    }

    if (lenght[i] > maxLenght)
    {
        maxLenght = lenght[i];
        lastIndex = i;
    }
}

lis = new int[maxLenght];

for (int i = 0; i < maxLenght; i++)
{
    lis[i] = numbers[lastIndex];
    lastIndex = prev[lastIndex];
}

Array.Reverse(lis);
Console.WriteLine(string.Join(" ", lis));