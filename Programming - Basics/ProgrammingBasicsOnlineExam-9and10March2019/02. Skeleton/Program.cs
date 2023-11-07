int minutsControl = int.Parse(Console.ReadLine());
int secondsControl = int.Parse(Console.ReadLine());
double meters = double.Parse(Console.ReadLine());
int secondsForMeters = int.Parse(Console.ReadLine());

double secondControl = minutsControl * 60 + secondsControl;
double time = meters / 120;
double totalTime = time * 2.5;
double timeMarin = (meters / 100) * secondsForMeters - totalTime;

if (timeMarin <= secondControl)
{
    Console.WriteLine("Marin Bangiev won an Olympic quota!");
    Console.WriteLine($"His time is {timeMarin:F3}.");
}
else if (timeMarin > secondControl)
{
    Console.WriteLine($"No, Marin failed! He was {Math.Abs(timeMarin - secondControl):F3} second slower.");
}
