double numberA = double.Parse(Console.ReadLine());
double numberB = double.Parse(Console.ReadLine());

bool isEqual = Math.Abs(numberA - numberB) < 0.000001;

if (isEqual)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}