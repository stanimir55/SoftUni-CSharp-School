int hours = int.Parse(Console.ReadLine());
int min = int.Parse(Console.ReadLine());

min = min + hours * 60;
min = min + 15;

hours = min / 60;
min = min % 60;

bool newDay = hours == 24;
if (newDay)
{
    Console.WriteLine($"0:{min:D2}") ;
}
else
{
    Console.WriteLine($"{hours}:{min:D2}");

}
