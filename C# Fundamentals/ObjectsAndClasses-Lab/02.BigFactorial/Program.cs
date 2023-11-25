using System.Numerics;

int number = int.Parse(Console.ReadLine());

BigInteger facturial = 1;

for (int i = number; i >= 1; i--)
{
    facturial *= i;
}

Console.WriteLine(facturial);