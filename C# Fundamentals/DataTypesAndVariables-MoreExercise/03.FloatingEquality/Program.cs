double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());
bool isEqual = Math.Abs(firstNumber - secondNumber) < 0.000001;

if (isEqual)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}
