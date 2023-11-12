int number = int.Parse(Console.ReadLine());

IsTopNumber(number);

static void IsTopNumber(int number)
{
    for (int i = 1; i < number; i++)
    {
        int digitsSum = 0;
        int oddsCounter = 0;
        string toString = i.ToString();

        for (int k = 0; k < toString.Length; k++)
        {
            int digit = int.Parse(toString[k].ToString());

            if (digit % 2 == 1)
            {
                oddsCounter++;
            }

            digitsSum += digit;
        }

        if (digitsSum % 8 == 0 && oddsCounter >= 1)
        {
            Console.WriteLine(i);
        }
    }
}
