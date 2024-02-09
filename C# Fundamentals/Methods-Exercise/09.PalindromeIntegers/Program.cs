int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    int digitsSum = 0;
    int oddsCounter = 0;
    string toString = i.ToString();

    FindTopNumber(ref digitsSum, ref oddsCounter, toString);

    if (digitsSum % 8 == 0 && oddsCounter >= 1)
    {
        Console.WriteLine(i);
    }
}

static void FindTopNumber(ref int digitsSum, ref int oddsCounter, string toString)
{
    for (int k = 0; k < toString.Length; k++)
    {
        int digit = int.Parse(toString[k].ToString());

        if (digit % 2 == 1)
        {
            oddsCounter++;
        }

        digitsSum += digit;
    }
}