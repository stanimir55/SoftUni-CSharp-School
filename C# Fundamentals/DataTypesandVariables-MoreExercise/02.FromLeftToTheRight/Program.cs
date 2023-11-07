int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    string num = Console.ReadLine();

    char delimiter = ' ';
    string[] splitNumbers = num.Split(delimiter);

    long leftNum = long.Parse(splitNumbers[0]);
    long rightNum = long.Parse(splitNumbers[1]);

    long biggerNumber = rightNum;

    if (leftNum > rightNum)
    {
        biggerNumber = leftNum;
    }

    long sum = 0;

    while (biggerNumber != 0)
    {
        sum += biggerNumber % 10;
        biggerNumber /= 10;
    }

    Console.WriteLine(Math.Abs(sum));
}
