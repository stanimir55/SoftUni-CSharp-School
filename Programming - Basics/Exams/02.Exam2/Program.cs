double breadthOfShip = double.Parse(Console.ReadLine());
double lengthOfShip = double.Parse(Console.ReadLine());
double heightOfShip = double.Parse(Console.ReadLine());
double averageHeight = double.Parse(Console.ReadLine());

double volume = breadthOfShip * lengthOfShip * heightOfShip;
double volumeRoom = (averageHeight + 0.40) * 2 * 2;
double freeSpace = Math.Floor(volume / volumeRoom);

if (freeSpace >= 3 && freeSpace <= 10)
{
    Console.WriteLine($"The spacecraft holds {freeSpace} astronauts.");
}
else if (freeSpace < 3)
{
    Console.WriteLine("The spacecraft is too small.");
}
else if (freeSpace > 10)
{
    Console.WriteLine("The spacecraft is too big.");
}