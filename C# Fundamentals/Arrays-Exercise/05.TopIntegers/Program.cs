int[] arr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

for (int i = 0; i < arr.Length; i++)
{
    bool topNumber = true;

    for (int k = i + 1; k < arr.Length; k++)
    {
        if (arr[i] <= arr[k])
        {
            topNumber = false;
        }
    }

    if (topNumber)
    {
        Console.Write($"{arr[i]} ");
    }
    
}
