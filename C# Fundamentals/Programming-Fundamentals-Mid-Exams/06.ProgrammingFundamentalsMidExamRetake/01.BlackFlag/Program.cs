int daysCount = int.Parse(Console.ReadLine());
int piratesPlunderForADay = int.Parse(Console.ReadLine());
int endExpectedPlunder = int.Parse(Console.ReadLine());
double result = 0;

for (int i = 1; i <= daysCount; i++)
{
    result += piratesPlunderForADay;

    if (i % 3 == 0)
    {
        result += piratesPlunderForADay * 0.5;
    }
    if (i % 5 == 0)
    {
        result *= 0.7;
    }
}

if (result >= endExpectedPlunder)
{
    Console.WriteLine($"Ahoy! {result:F2} plunder gained."); 
}
else
{
    Console.WriteLine($"Collected only {result / endExpectedPlunder * 100:F2}% of the plunder.");
}
