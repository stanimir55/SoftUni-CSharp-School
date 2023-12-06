List<string> arguments = Console.ReadLine()
    .Split()
    .ToList();

string first = arguments[0];
string second = arguments[1];
int sum = 0;

sum = CalculateSum(first, second);

Console.WriteLine(sum);


static int CalculateSum(string first, string second)
{
    char[] firstArr = first.ToCharArray();
    char[] secondArr = second.ToCharArray();
    int sum = 0;

    int minLenght = Math.Min(firstArr.Length, secondArr.Length);
    int maxLenght = Math.Max(firstArr.Length, secondArr.Length);

    for (int i = 0; i < minLenght; i++)
    {
        sum += firstArr[i] * secondArr[i];
    }

    if (maxLenght == firstArr.Length)
    {
        for (int i = minLenght; i < maxLenght; i++)
        {
            sum += firstArr[i];
        }
    }
    else
    {
        for (int i = minLenght; i < maxLenght; i++)
        {
            sum += secondArr[i];
        }
    }

    return sum;
}
