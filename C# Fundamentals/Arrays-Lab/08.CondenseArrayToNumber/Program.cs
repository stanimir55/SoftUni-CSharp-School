int[] number = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] num = new int[number.Length - 1];

for (int i = 0; i < number.Length; i++)
{
    if (number.Length == 1)
    {
        Console.WriteLine(number[0]);
        return;
    }
    for (int k = 0; k < num.Length - i; k++)
    {
        num[k] = number[k] + number[k + 1];
    }
    number = num;
}

Console.WriteLine(num[0]);
