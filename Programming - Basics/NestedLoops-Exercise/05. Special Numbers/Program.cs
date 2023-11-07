int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= 9; i++)
{
    for (int l = 1; l <= 9; l++)
    {
        for (int m = 1; m <= 9; m++)
        {
            for (int k = 1; k <= 9; k++)
            {
                if (n % i == 0 && n % l == 0 && n % m == 0 && n % k == 0)

                Console.Write($"{i}{l}{m}{k} ");
            }
        }
    }
}

