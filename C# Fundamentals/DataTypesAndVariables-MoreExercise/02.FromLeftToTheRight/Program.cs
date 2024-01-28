int linesCount = int.Parse(Console.ReadLine());

for (int i = 0; i < linesCount; i++)
{
    string[] numbers = Console.ReadLine()
        .Split();
    
    long leftNumber = long.Parse(numbers[0]);
    long rightNumber = long.Parse(numbers[1]);

    long sum = 0;
    long biggerNumber = rightNumber;

    if (leftNumber > biggerNumber)
    {
        biggerNumber = leftNumber;
    }

    while (biggerNumber != 0)
    {
        sum += biggerNumber % 10;
        biggerNumber /= 10;
    }

    Console.WriteLine(Math.Abs(sum));
}