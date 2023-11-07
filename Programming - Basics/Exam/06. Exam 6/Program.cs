int numK = int.Parse(Console.ReadLine());
int numL = int.Parse(Console.ReadLine());
int numM = int.Parse(Console.ReadLine());
int numN = int.Parse(Console.ReadLine());

int counter = 0;

for (int k = numK; k <= 8; k++)
{
    if (k % 2 == 1)
    {
        continue;
    }
    for (int l = 9; l >= numL; l--)
    {
        if (l % 2 == 0)
        {
            continue;
        }
        for (int m = numM; m <= 8; m++)
        {
            if (m % 2 == 1)
            {
                continue;
            }
            for (int n = 9; n >= numN; n--)
            {
                if (n % 2 == 0)
                {
                    continue;
                }

                if (k == m && l == n)
                {
                    Console.WriteLine("Cannot change the same player.");
                }
                else
                {
                    counter++;
                    Console.WriteLine($"{k}{l} - {m}{n}");
                }

                if (counter == 6)
                {
                    return;
                }

            }
        }
    }
}

