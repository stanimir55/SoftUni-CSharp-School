string number = Console.ReadLine();

int sum = 0;

for (int i = 0; i < number.Length; i++)
{
    int facturial = 1;

    int currentNumber = int.Parse(number[i].ToString());

    for (int k = 1; k <= currentNumber; k++)
    {
        facturiel *= k;
    }

    sum += facturiel;
}

if (sum == int.Parse(number))
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}