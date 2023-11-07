int fibonacciNumber = int.Parse(Console.ReadLine());

int[] fibonacciConstraints = new int[50];

fibonacciConstraints[0] = 1;
fibonacciConstraints[1] = 1;

if (fibonacciNumber >= 2)
{
    for (int i = 2; i < fibonacciNumber; i++)
    {
        fibonacciConstraints[i] = fibonacciConstraints[i - 1] + fibonacciConstraints[i - 2];
    }
}

Console.WriteLine(fibonacciConstraints[fibonacciNumber - 1]);