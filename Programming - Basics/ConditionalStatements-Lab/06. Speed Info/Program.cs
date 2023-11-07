double speed = double.Parse(Console.ReadLine());
if (speed <= 10.0) 
{
    Console.WriteLine("slow");
}
else if (speed <= 50.0)
{

    Console.WriteLine("average");
}
 else if (speed <= 150)
{
    Console.WriteLine("fast");
}
 else if (speed <= 1000)
{
    Console.WriteLine("ultra fast");
}
 else if (speed >= 1000)
{
    Console.WriteLine("extremely fast");
}
