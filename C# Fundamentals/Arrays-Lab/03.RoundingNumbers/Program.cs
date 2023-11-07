double[] numbers = Console.ReadLine()
    .Split()
    .Select(double.Parse)
    .ToArray();

foreach (double number in numbers)
{
    int rounted = (int)Math.Round(number, MidpointRounding.AwayFromZero);

    Console.WriteLine($"{number} => {rounted}");
}
