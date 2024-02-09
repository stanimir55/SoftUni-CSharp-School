int number = int.Parse(Console.ReadLine());

PrintNxNMatrix(number);

static void PrintNxNMatrix(int number)
{
    for (int i = 0; i < number; i++)
    {
        for (int k = 0; k < number; k++)
        {
            Console.Write($"{number} ");
        }

        Console.WriteLine();
    }
}