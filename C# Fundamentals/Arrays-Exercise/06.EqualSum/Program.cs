int[] arr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

bool isFound = false;

for (int i = 0; i < arr.Length; i++)
{
    int leftSum = 0;

    for (int k = 0; k < i; k++)
    {
        leftSum += arr[k];
    }

    int rightSum = 0;

    for (int m = arr.Length - 1; m > i; m--)
    {
        rightSum += arr[m];
    }

    if (leftSum == rightSum && !isFound)
    {
        Console.WriteLine(i);
        isFound = true;
    }
}

if (!isFound)
{
    Console.WriteLine("no");
}